using System;

namespace ShadowrunLogic
{
	public abstract class AbstractRangedWeapon : IManifestItem
	{
		public string TypeString(){
			return Skill().ToString();
		}

		public abstract int Damage();
		public abstract DamageType DamageType();
		public abstract int Accuracy();
		public abstract int AP ();
		public abstract RangedFiringModes FiringModes();
		public abstract int MagSize();
		public abstract string Name();
		public abstract int Recoil();
		public abstract RangedWeaponSkills Skill();

		public AbstractRangedWeapon Clone ()
		{
			return new CustomRangedWeapon(
				Damage (),
				DamageType (),
				Accuracy (),
				AP (),
				FiringModes (),
				MagSize (),
				Name (),
				Recoil (),
				Skill ()
			);
		}

	}
}

