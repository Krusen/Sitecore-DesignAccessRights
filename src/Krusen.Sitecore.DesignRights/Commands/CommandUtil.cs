using Krusen.Sitecore.DesignRights.Security;
using Sitecore;
using Sitecore.Shell.Framework.Commands;

namespace Krusen.Sitecore.DesignRights.Commands
{
    internal static class CommandUtil
    {
        public static CommandState GetDesignRightState(CommandState originalState, CommandContext commandContext)
        {
            if (commandContext.Items[0] == null) return originalState;

            // We don't want to enable it if it's disabled
            if (originalState != CommandState.Enabled) return originalState;

            return DesignAccessRight.IsAllowed(commandContext.Items[0], Context.User)
                ? originalState
                : CommandState.Hidden;
        }
    }
}
