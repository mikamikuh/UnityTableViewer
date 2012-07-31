using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace UnityTableViewer.Provider {
	public class ContentProvider : IContentProvider {
		
		private IList<Object> prefabs;
		private int rowCount;
		private int colCount;
		
		public IList<Object> Prefabs {
			get { return this.prefabs; }
		}
		
		public int RowCount {
			get { return this.rowCount; }
		}
		
		public int ColCount {
			get { return this.colCount; }
		}
		
		public ContentProvider() {
			prefabs = new List<Object>();
		}
	}
}