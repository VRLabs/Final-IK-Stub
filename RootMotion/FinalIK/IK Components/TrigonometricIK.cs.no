using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK 
    {
        public IKSolverTrigonometric solver = new IKSolverTrigonometric();

	}
}
