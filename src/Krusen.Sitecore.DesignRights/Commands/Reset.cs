using Sitecore.Shell.Framework.Commands;

namespace Krusen.Sitecore.DesignRights.Commands
{
    public class Reset : global::Sitecore.Shell.Applications.Layouts.PageDesigner.Commands.Reset
    {
        public override CommandState QueryState(CommandContext context)
        {
            return CommandUtil.GetDesignRightState(base.QueryState(context), context);
        }
    }
}
