using System;
using UnityEngine;
using System.Collections;

namespace UnityTableViewer.Provider {
	public interface ICellData {
		string Name { get; }
		System.Object Data { get; set; }
	}
}