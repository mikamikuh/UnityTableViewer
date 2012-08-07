using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityTableViewer.Provider {
	public interface ICellProvider {
		int Count { get; }
		string GetLabel(int col, Object obj);
		Func<Object> GetCellAccessor(Object obj);
	}
}