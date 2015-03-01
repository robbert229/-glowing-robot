using System;
using Gtk;

using ShadowrunLogic;
using ShadowrunCoreContent;
using System.Collections.Generic;
using ShadowrunGui;

public partial class ShadowrunToolMainWindow: Gtk.Window
{	
	List<IManifest<IRangedWeapon>> rangedWeaponManifests;

	public ShadowrunToolMainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		rangedWeaponManifests = new List<IManifest<IRangedWeapon>>();

		LoadContentFromManifests();


	}

	private void LoadContentFromManifests ()
	{
		rangedWeaponManifests.Add(new ShadowrunCoreContent.RangedWeaponsManifest());
	}



	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	#region FormEvents
	protected void AttributeImport_Click (object sender, EventArgs e)
	{


	}

	protected void RangedWeaponImport_Click (object sender, EventArgs e)
	{
		using (var rangedWeaponImportWindow = new RangedWeaponImportWindow (rangedWeaponManifests)) {
			rangedWeaponImportWindow.TransientFor = this;
			rangedWeaponImportWindow.Modal = true;
			rangedWeaponImportWindow.Show();

			while (rangedWeaponImportWindow.selectedRangedWeapon == null)
				Application.RunIteration(true);

			SetRenderedRangedWeapon(rangedWeaponImportWindow.selectedRangedWeapon);
		}
	}
	#endregion

	#region DisplayStuff
	protected void SetRenderedRangedWeapon (IRangedWeapon r)
	{
		RangedWeaponName_Textbox.Text = r.Name ();
		RangedDamage_Textbox.Text = r.Damage ().ToString ();
		if (r.DamageType () == DamageType.Stun)
			RangedStunDamage_Radio.Activate ();
		else 
			RangedPhysicalDamage_Radio.Activate ();
		RangedAccuracy_Textbox.Text = r.Accuracy ().ToString ();
		RangedWeaponAP_Textbox.Text = r.AP ().ToString ();

		var modes = r.FiringModes ();
		SingleShot_Checkbox.Active = modes.SingleShot;
		SemiAutomatic_Checkbox.Active = modes.SemiAutomatic;
		SemiAutomaticBurst_Checkbox.Active = modes.SemiAutomaticBurst;
		BurstFire_Checkbox.Active = modes.BurstFire;
		LongBurst_Checkbox.Active = modes.LongBurst;
		FullAuto_Checkbox.Active = modes.FullAuto;
	}

	protected void SetRenderedMeleeWeapon(IMeleeWeapon m){


	}
	#endregion

}
