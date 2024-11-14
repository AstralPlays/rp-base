using Sandbox.Utility;
using Sandbox.Events;

namespace astral_base.SCPRP;

public partial class Player
{
    [HostSync]
	[Property]
    public Team Team { get; set; }
    
    public void SetTeam(Team team)
    {
        Log.Info( $"{this} has changed their team from {Team} to: {team}" );
        Team = team;
    }
}
