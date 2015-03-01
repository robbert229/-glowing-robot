using System;
using ShadowrunLogic;
using System.Collections.Generic;
using ShadowrunCoreContent;


namespace ShadowrunGui
{
	public partial class RangedWeaponImportWindow : Gtk.Window
	{
		List<IManifest<IRangedWeapon>> weapons;

		public IRangedWeapon selectedRangedWeapon;

		public RangedWeaponImportWindow (List<IManifest<IRangedWeapon>> weapons) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.weapons = weapons;

			BuildTree();
		}

		private void BuildTree(){
			WeaponList_TreeView.AppendColumn("Name", new Gtk.CellRendererText(),"text",0);
			WeaponList_TreeView.AppendColumn("Type", new Gtk.CellRendererText(),"text",1);
			Gtk.TreeStore weaponStore = new Gtk.TreeStore(typeof(string),typeof(string));

			foreach (IManifest<IRangedWeapon> man in weapons) {
				Gtk.TreeIter iter = weaponStore.AppendValues(man.PackName());

				foreach(IRangedWeapon weapon in man.GetContents()){
					weaponStore.AppendValues(iter,weapon.Name(),weapon.WeaponType().ToString());
				}
			}

			WeaponList_TreeView.Model = weaponStore;
		}

		protected void TreeViewSelect_Click (object sender, EventArgs e)
		{
			Gtk.TreeIter selected;
			WeaponList_TreeView.Selection.GetSelected (out selected);
			string selectedWeaponName = WeaponList_TreeView.Model.GetValue (selected, 0).ToString();

			foreach (var man in weapons) {
				foreach(var weapon in man.GetContents()){
					if(weapon.Name() == selectedWeaponName){
						selectedRangedWeapon = weapon;
						this.Destroy();
						return;
					}
				}
			}
			

		}
	}
}

