using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace UnityTableViewer.Provider {
	public interface IContentProvider {
		int RowCount { get; }
		int ColCount { get; }
		IList<Object> Prefabs { get; }
	}
}