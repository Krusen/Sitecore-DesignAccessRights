using Sitecore;

namespace Krusen.Sitecore.DesignRights.ExperienceEditor.Requests.AddRendering
{
    public class CanAddRendering : global::Sitecore.ExperienceEditor.Speak.Ribbon.Requests.AddRendering.CanAddRendering
    {
        public override bool GetControlState()
        {
            return base.GetControlState() && DesignAccessRight.IsAllowed(RequestContext.Item, Context.User);
        }
    }
}
