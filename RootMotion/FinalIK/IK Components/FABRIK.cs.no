using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK 
    {
		public IKSolverFABRIK solver = new IKSolverFABRIK();
    }
}

