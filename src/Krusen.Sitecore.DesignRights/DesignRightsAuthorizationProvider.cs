using Sitecore.Buckets.Security;
using Sitecore.Security.AccessControl;

namespace Krusen.Sitecore.DesignRights
{
    public class DesignRightsAuthorizationProvider : BucketAuthorizationProvider
    {
        private ItemAuthorizationHelper _itemHelper;
        private FieldAuthorizationHelper _fieldHelper;

        public DesignRightsAuthorizationProvider()
        {
            _itemHelper = new DesignRightsItemAuthorizationHelper();
            _fieldHelper = new DesignRightsFieldAuthorizationHelper();
        }

        protected override ItemAuthorizationHelper ItemHelper
        {
            get { return _itemHelper; }
            set { _itemHelper = value; }
        }

        protected override FieldAuthorizationHelper FieldHelper
        {
            get { return _fieldHelper; }
            set { _fieldHelper = value; }
        }
    }
}
