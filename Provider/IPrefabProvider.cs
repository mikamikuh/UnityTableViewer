using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IPrefabProvider {
	int RowCount { get; }
	int ColCount { get; }
	IList<Object> Prefabs { get; }
}
