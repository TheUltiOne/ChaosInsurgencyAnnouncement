using System.ComponentModel;
using Exiled.API.Interfaces;

namespace ChaosInsurgencyAnnouncement
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Sets the message Cassie says when Chaos Insurgency spawned.")]
        public string Announcement { get; set; } = "CHAOS INSURGENCY HAS ENTERED THE FACILITY ALL REMAINING PERSONNEL ARE ADVISED TO PROCEED WITH STANDARD EVACUATION PROTOCOL UNTIL NO DANGER IS LEFT";

        [Description("Sets the delay until the announcement")]
        public float Delay { get; set; } = 0.5f;
    }

}