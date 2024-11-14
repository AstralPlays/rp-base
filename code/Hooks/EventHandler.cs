using Sandbox.Utility;
using Sandbox.Events;

namespace astral_base.SCPRP;

public class EventHandler : GameObjectSystem<EventHandler>, 
IGameEventHandler<PlayerTookDamage>, 
IGameEventHandler<PlayerTakeDamage>,
IGameEventHandler<PlayerChangeTeam>
{
	public EventHandler(Scene scene) : base(scene) { }

	public bool OnGameEvent( PlayerTookDamage eventArgs )
	{
		var player = eventArgs.player;
		var damage = eventArgs.damage;

		Log.Info($"{player.SteamID} is took {damage.Amount} ammount of damage.");
		return false;
	}

	public bool OnGameEvent( PlayerTakeDamage eventArgs )
	{
		var player = eventArgs.player;
		var damage = eventArgs.damage;

		Log.Info($"{player.SteamID} is attempting to take {damage.Amount} ammount of damage.");

		player.ActualTakeDamage(damage);
		return false;
	}

	public bool OnGameEvent( PlayerChangeTeam eventArgs )
	{
		Player player = eventArgs.player;
		Team team = eventArgs.team;

		Log.Info($"{player.SteamID} is attempting to change to team {team} ");

		player.SetTeam(team);

		return false;
	}
}
