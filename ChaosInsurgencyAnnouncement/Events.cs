using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace ChaosInsurgencyAnnouncement
{
    class Events
    {
        public void OnRespawningTeam(RespawningTeamEventArgs ev) {
            if (ev.NextKnownTeam == Respawning.SpawnableTeamType.ChaosInsurgency)
            {
                Cassie.DelayedMessage(ChaosInsurgencyAnnouncement.Instance.Config.Announcement, ChaosInsurgencyAnnouncement.Instance.Config.Delay, true);
            }
        }
    }
}
