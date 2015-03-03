using System;

namespace ShadowrunLogic
{
	public abstract class AbstractRangedWeapon : IManifestItem
	{
		public string TypeString(){
			return WeaponType().ToString();
		}

		public abstract int Damage();
		public abstract DamageType DamageType();
		public abstract int Accuracy();
		public abstract int AP ();
		public abstract RangedWeaponType WeaponType();
		public abstract RangedFiringModes FiringModes();
		public abstract int MagSize();
		public abstract string Name();
		public abstract int Recoil();
		public abstract RangedWeaponSkills Skill();
	}
}

