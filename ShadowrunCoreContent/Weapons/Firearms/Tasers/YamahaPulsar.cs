using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class YamahaPulsar : IRangedWeapon
	{
		public int Damage() {
			return 7;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Stun;
		}

		public int Accuracy() {
			return 5;
		}

		public int AP ()
		{
			return -5;
		}

		public RangedWeaponType WeaponType() {
			return RangedWeaponType.Tazer;
		}

		public RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			return rfm;
		}

		public int MagSize(){
			return 4;
		}

		public string Name(){
			return "Yamaha Pulsar";
		}

		public int Recoil(){
			return 0;
		}
	}

}

