using Krusen.Sitecore.DesignRights.Security;
using Sitecore;

namespace Krusen.Sitecore.DesignRights.ExperienceEditor.Requests.LayoutPresets
{
    public class CanOpenRequest : global::Sitecore.ExperienceEditor.Speak.Ribbon.Requests.LayoutPresets.CanOpenRequest
    {
        public override bool GetControlState()
        {
            return base.GetControlState() && DesignAccessRight.IsAllowed(RequestContext.Item, Context.User);
        }
    }
}
