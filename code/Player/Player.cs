using Sandbox.Utility;
using Sandbox.Events;

namespace astral_base.SCPRP;

public sealed partial class Player : Component
{
	/// The current character controller for this player.
	[HostSync]
	[RequireComponent]
	public CharacterController CharacterController { get; set; } // Save this for easy acces to the player.

	[HostSync]
	[Property]
	public ulong SteamID { get; set; }

	[HostSync]
	[Property]
	public string SteamName { get; set; }

	[HostSync]
	[Property]
	public string DisplayName { get; set; } // Display Name, Use SteamName as fallback.

	[Broadcast]
	protected override void OnAwake()
    {
		CharacterController = GetComponent<CharacterController>();
		SteamName = Steam.PersonaName;
		SteamID = Steam.SteamId;

		DisplayName = SteamName; // For now till we add functionality to this.
		Log.Info( $"Loaded: {SteamName}'s information. With the SteamID: {SteamID}" );
		Scene.Dispatch( new PlayerLoadedIn( this ) );
    }

	protected override void OnPreRender()
	{
		if ( Scene.Camera is null )
			return;

		var hud = Scene.Camera.Hud;

		hud.DrawText( new TextRendering.Scope( this.Health.ToString(), Color.Red, 32 ), Screen.Width * 0.5f );
		hud.DrawText( new TextRendering.Scope( this.Armor.ToString(), Color.Red, 32 ), Screen.Width * 0.3f );
	}
}
