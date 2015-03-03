using System;


namespace ShadowrunLogic
{
	public interface IMeleeWeapon : IManifestItem
	{
		int Damage();
		DamageType DamageType();
		int AP();
		MeleeWeaponType WeaponType();
		string Name();
		int Accuracy();
	}
}

