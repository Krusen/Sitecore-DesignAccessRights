using Sitecore.Shell.Framework.Commands;

namespace Krusen.Sitecore.DesignRights.Commands
{
    public class SetLayoutDetails : global::Sitecore.Shell.Framework.Commands.SetLayoutDetails
    {
        public override CommandState QueryState(CommandContext context)
        {
            return CommandUtil.GetDesignRightState(base.QueryState(context), context);
        }
    }
}
