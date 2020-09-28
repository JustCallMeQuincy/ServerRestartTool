using System.ComponentModel;
using Exiled.API.Interfaces;

namespace ServerRestartTool
{
    public sealed class Config : IConfig
    {
        [Description("Enables/disables the plugin. Defaults to true.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Sets the amount of rounds after which the server will be automatically restarted. Defaults to 5.")]
        public int AutoRestartAfter { get; set; } = 5;
    }
}
