using Exiled.API.Enums;
using Exiled.API.Features;

using HServer = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;
using Map = Exiled.Events.Handlers.Map;


using System;

namespace ChaosInsurgencyAnnouncement
{
    public class ChaosInsurgencyAnnouncement : Plugin<Config>
    {
        private static readonly Lazy<ChaosInsurgencyAnnouncement> LazyInstance = new Lazy<ChaosInsurgencyAnnouncement>(valueFactory: () => new ChaosInsurgencyAnnouncement());
        public static ChaosInsurgencyAnnouncement Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Events events;

        private ChaosInsurgencyAnnouncement()
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
            events = new Events();
            HServer.RespawningTeam += events.OnRespawningTeam;
        }

        public void UnregisterEvents()
        {
            HServer.RespawningTeam -= events.OnRespawningTeam;
            events = null;
        }
    }
}
