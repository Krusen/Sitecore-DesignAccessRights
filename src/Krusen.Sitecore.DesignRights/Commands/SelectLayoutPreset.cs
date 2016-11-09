using Sitecore.Shell.Framework.Commands;

namespace Krusen.Sitecore.DesignRights.Commands
{
    public class SelectLayoutPreset : global::Sitecore.Shell.Applications.WebEdit.Commands.SelectLayoutPreset
    {
        public override CommandState QueryState(CommandContext context)
        {
            return CommandUtil.GetDesignRightState(base.QueryState(context), context);
        }
    }
}
