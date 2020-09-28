using Exiled.API.Features;

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
