using System;
using Gtk;

using ShadowrunLogic;
using ShadowrunCoreContent;
using System.Collections.Generic;
using ShadowrunGui;

public partial class ShadowrunToolMainWindow: Gtk.Window
{	
	List<IManifest<IManifestItem>> rangedWeaponManifests;
	List<IManifest<IManifestItem>> meleeWeaponManifests;
	List<IManifest<IManifestItem>> attributeManifests;

	public ShadowrunToolMainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		rangedWeaponManifests = new List<IManifest<IManifestItem>>();
		meleeWeaponManifests = new List<IManifest<IManifestItem>>();
		LoadContentFromManifests();
	}

	private void LoadContentFromManifests ()
	{
		rangedWeaponManifests.Add(new ShadowrunCoreContent.RangedWeaponsManifest());
		meleeWeaponManifests.Add (new ShadowrunCoreContent.MeleeWeaponsManifest());
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
		var rangedImportWeaponWindow = new ImportWindow(rangedWeaponManifests);
		rangedImportWeaponWindow.TransientFor = this;

		rangedImportWeaponWindow.Destroyed+= delegate {
			if(rangedImportWeaponWindow.selectedItem == null)
				return;
			var selectedRangedWeapon = (IRangedWeapon)rangedImportWeaponWindow.selectedItem;
			SetRenderedRangedWeapon(selectedRangedWeapon);
		};
	}

	protected void MeleeWeaponImport_Click (object sender, EventArgs e)
	{
		var meleeImportWeaponWindow = new ImportWindow(meleeWeaponManifests);
		meleeImportWeaponWindow.TransientFor = this;

		meleeImportWeaponWindow.Destroyed+= delegate {
			if(meleeImportWeaponWindow.selectedItem == null)
				return;
			var selectedMeleeWeapon = (IMeleeWeapon)meleeImportWeaponWindow.selectedItem;
			SetRenderedMeleeWeapon(selectedMeleeWeapon);
		};
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
		RangedRecoil_Textbox.Text = r.Recoil().ToString();

		var modes = r.FiringModes ();
		SingleShot_Checkbox.Active = modes.SingleShot;
		SemiAutomatic_Checkbox.Active = modes.SemiAutomatic;
		SemiAutomaticBurst_Checkbox.Active = modes.SemiAutomaticBurst;
		BurstFire_Checkbox.Active = modes.BurstFire;
		LongBurst_Checkbox.Active = modes.LongBurst;
		FullAuto_Checkbox.Active = modes.FullAuto;
	}

	protected void SetRenderedMeleeWeapon(IMeleeWeapon m){
		MeleeWeaponName_Textbox.Text = m.Name();
		MeleeAP_Textbox.Text = m.AP().ToString();

		if(m.DamageType() == DamageType.Stun)
			MeleeStunDamage_Radio.Activate();
		else 
			MeleePhysicalDamage_Radio.Activate ();

		MeleeDamage_Textbox.Text = m.Damage().ToString();

	}
	#endregion
}