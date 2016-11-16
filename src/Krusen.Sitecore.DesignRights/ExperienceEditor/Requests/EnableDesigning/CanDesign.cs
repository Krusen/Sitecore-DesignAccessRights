using Krusen.Sitecore.DesignRights.Security;
using Sitecore;

namespace Krusen.Sitecore.DesignRights.ExperienceEditor.Requests.EnableDesigning
{
    public class CanDesign : global::Sitecore.ExperienceEditor.Speak.Ribbon.Requests.EnableDesigning.CanDesign
    {
        public override bool GetState()
        {
            return base.GetState() && DesignAccessRight.IsAllowed(RequestContext.Item, Context.User);
        }
    }
}
