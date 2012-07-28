using UnityEngine;
using System.Collections;

namespace UnityTableViewer.Generator {
	public abstract class CodeGenerator : ICodeGenerator {
		public abstract void execute();
	}
}