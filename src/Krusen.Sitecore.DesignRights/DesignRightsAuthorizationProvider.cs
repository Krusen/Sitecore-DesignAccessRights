using Sitecore.Buckets.Security;
using Sitecore.Security.AccessControl;

namespace Krusen.Sitecore.DesignRights
{
    public class DesignRightsAuthorizationProvider : BucketAuthorizationProvider
    {
        private ItemAuthorizationHelper _itemHelper;

        public DesignRightsAuthorizationProvider()
        {
            _itemHelper = new DesignRightsAuthorizationHelper();
        }

        protected override ItemAuthorizationHelper ItemHelper
        {
            get { return _itemHelper; }
            set { _itemHelper = value; }
        }
    }
}
