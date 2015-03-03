using System;

namespace ShadowrunLogic
{
	public class CustomRangedWeapon : AbstractRangedWeapon
	{
		private int damage;
		private DamageType damageType;
		private int accuracy;
		private int ap;
		private RangedWeaponType rangedWeaponType;
		private RangedFiringModes rangedFiringModes;
		private int magSize;
		private string name;
		private int recoil;

		public CustomRangedWeapon (int damage,DamageType damageType,
		                           int accuracy,int ap,RangedWeaponType rangedWeaponType,
		                           RangedFiringModes rangedFiringModes,int magSize,string name,int recoil)
		{
			this.damage = damage;
			this.damageType = damageType;
			this.accuracy = accuracy;
			this.ap = ap;
			this.rangedWeaponType = rangedWeaponType;
			this.rangedFiringModes = rangedFiringModes;
			this.magSize = magSize;
			this.name = name;
			this.recoil = recoil;
		}
		#region implemented abstract members of ShadowrunLogic.AbstractRangedWeapon
		public override int Damage ()
		{
			return damage;
		}

		public override ShadowrunLogic.DamageType DamageType ()
		{
			return damageType;
		}

		public override int Accuracy ()
		{
			return accuracy;
		}

		public override int AP ()
		{
			return ap;
		}

		public override RangedWeaponType WeaponType ()
		{
			return rangedWeaponType;
		}

		public override RangedFiringModes FiringModes ()
		{
			return rangedFiringModes;
		}

		public override int MagSize ()
		{
			return magSize;
		}

		public override string Name ()
		{
			return name;
		}

		public override int Recoil ()
		{
			return recoil;
		}
		#endregion

	}
}

