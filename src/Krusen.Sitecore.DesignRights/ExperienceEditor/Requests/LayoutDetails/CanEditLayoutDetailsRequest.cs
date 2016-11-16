using Krusen.Sitecore.DesignRights.Security;
using Sitecore;

namespace Krusen.Sitecore.DesignRights.ExperienceEditor.Requests.LayoutDetails
{
    public class CanEditLayoutDetailsRequest : global::Sitecore.ExperienceEditor.Speak.Ribbon.Requests.LayoutDetails.CanEditLayoutDetailsRequest
    {
        public override bool GetControlState()
        {
            return base.GetControlState() && DesignAccessRight.IsAllowed(RequestContext.Item, Context.User);
        }
    }
}
