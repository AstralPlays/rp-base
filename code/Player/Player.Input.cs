using Sandbox.Utility;
using Sandbox.Events;

namespace astral_base.SCPRP;

public partial class Player
{
    private GameObject ActiveWeapon;

	protected override void OnUpdate()
	{
		base.OnUpdate();

		if (!Input.Pressed( "attack1" ) ){ return;}
		if (this.ActiveWeapon.IsValid()) { return; }
	}
}
