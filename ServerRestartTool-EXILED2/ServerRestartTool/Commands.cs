using System;
using System.Diagnostics;
using System.Windows.Input;
using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using MEC;

namespace ServerRestartTool
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Restart : ICommand
    {

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {

            if (!(sender as CommandSender).CheckPermission("s.restart"))
            {

                response = "You have invalid permissions to restart the server.";
                return false;
            }

            Round.Restart();
            Timing.CallDelayed(delay: 1.5f, action: () => Process.GetCurrentProcess().Kill());
            response = "Restarting server...";
            return true;
        }


        public string Command => "srestart";
        public string[] Aliases => new string["sr"];
        public string Description => "Restarts the server.";
    }
}
