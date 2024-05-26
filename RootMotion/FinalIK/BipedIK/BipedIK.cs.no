using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager 
    {
        public BipedReferences references = new BipedReferences();
		public BipedIKSolvers solvers = new BipedIKSolvers();
    }
}
