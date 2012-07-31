using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityTableViewer.Provider {
	public class ContentProvider : IContentProvider {
		
		private IList<ICellProvider> contents;
		
		public IList<ICellProvider> Contents {
			get { return this.contents; }
		}
		
		public int Count {
			get { return this.contents.Count; }
		}
		
		public ContentProvider() {
			contents = new List<ICellProvider>();
		}
	}
}