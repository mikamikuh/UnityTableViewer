using UnityEngine;
using System.Collections;

namespace UnityTableEditor.Provider {
	
	public interface IControlProvider {
		void drawControl(ControlType type, string data);
	}
	
	public enum ControlType {
		TEXT,
		VECTOR_2D,
		VECTOR_3D
	}
}
