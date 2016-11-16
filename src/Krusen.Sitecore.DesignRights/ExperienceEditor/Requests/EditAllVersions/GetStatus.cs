using Krusen.Sitecore.DesignRights.Security;
using Sitecore;

namespace Krusen.Sitecore.DesignRights.ExperienceEditor.Requests.EditAllVersions
{
    public class GetStatus : global::Sitecore.ExperienceEditor.Speak.Ribbon.Requests.EditAllVersions.GetStatus
    {
        public override bool GetControlState()
        {
            return base.GetControlState() && DesignAccessRight.IsAllowed(RequestContext.Item, Context.User);
        }
    }
}
