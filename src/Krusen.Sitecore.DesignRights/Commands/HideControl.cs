using Sitecore.Shell.Framework.Commands;

namespace Krusen.Sitecore.DesignRights.Commands
{
    public class HideControl : global::Sitecore.ExperienceEditor.WebEdit.Commands.HideControl
    {
        public override CommandState QueryState(CommandContext context)
        {
            return CommandUtil.GetDesignRightState(base.QueryState(context), context);
        }
    }
}
