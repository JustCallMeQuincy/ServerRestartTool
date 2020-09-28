using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using Server = Exiled.Events.Handlers.Server;

namespace ServerRestartTool
{
    public class ServerRestartTool : Plugin<Config>
    {
        private static readonly Lazy<ServerRestartTool> LazyInstance = new Lazy<ServerRestartTool>(valueFactory:() => new ServerRestartTool);
        public static ServerRestartTool Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Server server;

        private ServerRestartTool()
        {
        }

        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            server = new Handlers.Server();
;
            Server.OnRoundEnd += server.OnRoundEnded;
            Server.roundsended += server.roundsended;
        }

        public void UnregisterEvents()
        {
            Server.OnRoundEnd += server.OnRoundEnded;
            Server.roundsended += server.roundsended;

            server = null;
        }
    }
}
