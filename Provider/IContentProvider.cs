using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityTableViewer.Provider {
	public interface IContentProvider {
		int Count { get; }
		IList<ICellData> Contents { get; }
	}
}