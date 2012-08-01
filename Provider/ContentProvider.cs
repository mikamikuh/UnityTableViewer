using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityTableViewer.Provider {
	public class ContentProvider : IContentProvider {
		
		private IList<ICellData> contents;
		
		public IList<ICellData> Contents {
			get { return this.contents; }
		}
		
		public int Count {
			get { return this.contents.Count; }
		}
		
		public ContentProvider(List<ICellData> contents) {
			contents = this.contents;
		}
	}
}