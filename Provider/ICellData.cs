using UnityEngine;
using System.Collections;

namespace UnityTableViewer.Provider {
	public interface ICellData {
		string Name { get; }
		string Get { get; }
		string Set { set; }
	}
}