using System;
using ShadowrunLogic;
using System.Collections.Generic;
using ShadowrunCoreContent;


namespace ShadowrunGui
{
	public partial class ItemImportWindow : Gtk.Window
	{
		private List<IManifest<IManifestItem>> items;
		public IManifestItem selectedItem;

		public ItemImportWindow (List<IManifest<IManifestItem>> items,string title) : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.items = items;
			this.Title = title;

			Modal = true;
			BuildTree();

			Show();
		}

		private void BuildTree(){
			Item_TreeView.AppendColumn("Name", new Gtk.CellRendererText(),"text",0);
			Item_TreeView.AppendColumn("Type", new Gtk.CellRendererText(),"text",1);
			Gtk.TreeStore weaponStore = new Gtk.TreeStore(typeof(string),typeof(string));

			foreach (IManifest<IManifestItem> man in items) {
				Gtk.TreeIter iter = weaponStore.AppendValues(man.PackName());

				foreach(IManifestItem weapon in man.GetContents()){
					weaponStore.AppendValues(iter,weapon.Name(),weapon.TypeString());
				}
			}

			Item_TreeView.Model = weaponStore;
		}

		protected void TreeViewSelect_Click (object sender, EventArgs e)
		{
			Gtk.TreeIter selected;
			Item_TreeView.Selection.GetSelected (out selected);
			string selectedItemName = Item_TreeView.Model.GetValue (selected, 0).ToString();

			foreach (IManifest<IManifestItem> man in items) {
				foreach(IManifestItem item in man.GetContents()){
					if(item.Name() == selectedItemName){
						selectedItem = item;
						this.Destroy();
						return;
					}
				}
			}
		}
	}
}

