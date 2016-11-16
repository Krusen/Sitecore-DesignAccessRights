using System.Collections.Generic;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Security.AccessControl;
using Sitecore.Security.Accounts;

namespace Krusen.Sitecore.DesignRights
{
    class DesignRightsFieldAuthorizationHelper : FieldAuthorizationHelper
    {
        private static readonly HashSet<ID> LayoutFieldIDs = new HashSet<ID>
        {
            FieldIDs.LayoutField,
            FieldIDs.FinalLayoutField
        };

        public override AccessResult GetAccess(Field field, Account account, AccessRight accessRight)
        {
            AccessResult result = null;

            if (ShouldCheckDesignRights(field, accessRight))
                result = GetLayoutFieldAccess(field, account, accessRight);

            return result ?? base.GetAccess(field, account, accessRight);
        }

        private static bool ShouldCheckDesignRights(Field field, AccessRight accessRight)
        {
            return accessRight == AccessRight.FieldWrite && LayoutFieldIDs.Contains(field.ID);
        }

        private static AccessResult GetLayoutFieldAccess(Field field, Account account, AccessRight accessRight)
        {
            var accessResult = DesignAccessRight.GetAccess(field.Item, account);
            if (accessResult.Permission == AccessPermission.Allow)
                return null;

            return new AccessResult(AccessPermission.Deny, accessResult.Explanation); ;
        }
    }
}
