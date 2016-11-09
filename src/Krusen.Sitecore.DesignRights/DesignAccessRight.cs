using System;
using Sitecore.Data.Items;
using Sitecore.Security.AccessControl;
using Sitecore.Security.Accounts;

namespace Krusen.Sitecore.DesignRights
{
    public class DesignAccessRight : AccessRight
    {
        public const string DefaultAccessRightName = "item:customdesign";

        public static string AccessRightName { get; } =
            global::Sitecore.Configuration.Settings.GetSetting("DesignRights.AccessRightName", DefaultAccessRightName);

        private static readonly Lazy<AccessRight> _accessRight = new Lazy<AccessRight>(() => FromName(AccessRightName));
        public static AccessRight AccessRight => _accessRight.Value;

        public DesignAccessRight(string name) : base(name)
        {
        }

        public static bool IsAllowed(Item item, Account account)
        {
            return AuthorizationManager.IsAllowed(item, AccessRight, account);
        }

        public static bool IsDenied(Item item, Account account)
        {
            return AuthorizationManager.IsDenied(item, AccessRight, account);
        }

        public static AccessResult GetAccess(Item item, Account account)
        {
            return AuthorizationManager.GetAccess(item, account, AccessRight);
        }
    }
}
