using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace ServerRestartTool.Handlers
{
    class Server
    {
        public int roundsended = 0;
        public void OnRoundEnd()
        {
            Log.Info(message: "Round ended.");
            Map.Broadcast(duration: 10, message: "Round ended! GG!");
            roundsended++;
        }
    }
}
