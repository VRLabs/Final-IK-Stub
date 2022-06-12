using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK 
    {
		public IKSolverCCD solver = new IKSolverCCD();
    }
}
