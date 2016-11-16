using Krusen.Sitecore.DesignRights.Security;
using Sitecore;

namespace Krusen.Sitecore.DesignRights.ExperienceEditor.Requests.ResetLayout
{
    public class IsEnabled : global::Sitecore.ExperienceEditor.Speak.Ribbon.Requests.ResetLayout.IsEnabled
    {
        public override bool GetControlState()
        {
            return base.GetControlState() && DesignAccessRight.IsAllowed(RequestContext.Item, Context.User);
        }
    }
}
