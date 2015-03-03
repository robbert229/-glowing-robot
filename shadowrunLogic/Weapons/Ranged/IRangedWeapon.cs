using System;

namespace ShadowrunLogic
{
	public interface IRangedWeapon : IManifestItem
	{
		int Damage();
		DamageType DamageType();
		int Accuracy();
		int AP();
		RangedWeaponType WeaponType();
		RangedFiringModes FiringModes();
		int MagSize();
		string Name();
		int Recoil();
	}
}

