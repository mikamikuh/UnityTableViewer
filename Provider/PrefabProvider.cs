using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PrefabProvider : IPrefabProvider {
	
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
	
	public PrefabProvider() {
		prefabs = new List<Object>();
	}
}
