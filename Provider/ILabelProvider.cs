using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityTableViewer.Provider {
	public interface ICellProvider {
		string GetLabel(int col, Object obj);
		Func<Object> GetCellAccessor(int col, Object obj);
	}
}