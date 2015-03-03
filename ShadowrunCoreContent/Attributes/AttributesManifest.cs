using System;
using ShadowrunLogic;
using System.Collections.Generic;

namespace ShadowrunCoreContent
{
	public class AttributesManifest : IManifest<IManifestItem>
	{
		private List<IManifestItem> contents;
		public AttributesManifest ()
		{
			contents = new List<IManifestItem>();
			contents.Add(new GangerAttributes());

		}

		public List<IManifestItem> GetContents ()
		{
			return contents;
		}

		public string PackName ()
		{
			return "Shadowrun Core";
		}
	}
}

