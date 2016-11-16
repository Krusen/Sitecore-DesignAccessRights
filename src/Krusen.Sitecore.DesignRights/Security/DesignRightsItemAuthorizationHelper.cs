using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Security.AccessControl;
using Sitecore.Security.Accounts;

namespace Krusen.Sitecore.DesignRights.Security
{
    public class DesignRightsItemAuthorizationHelper : ItemAuthorizationHelper
    {
        private static readonly ID PolicyCanDesignID = ID.Parse("{5A524BAD-2257-4330-9CAD-A2DCB1111A66}");

        protected override AccessResult GetItemAccess(Item item, Account account, AccessRight accessRight,
            PropagationType propagationType)
        {
            var result = base.GetItemAccess(item, account, accessRight, propagationType);

            // We don't want to overrule other permissions not allowing access (write access etc.)
            if (result?.Permission != AccessPermission.Allow)
                return result;

            // Only check if the item is the "CanDesign" policy item or if context item is not null
            // Context item can be null for some requests in the Content Editor
            if (!ShouldCheckDesignRights(item))
                return result;

            var designAccessResult = DesignAccessRight.GetAccess(Context.Item, account);
            if (designAccessResult.Permission != AccessPermission.Allow)
                return designAccessResult;

            return result;
        }

        private static bool ShouldCheckDesignRights(Item item)
        {
            return item.ID == PolicyCanDesignID && Context.Item != null;
        }
    }
}
