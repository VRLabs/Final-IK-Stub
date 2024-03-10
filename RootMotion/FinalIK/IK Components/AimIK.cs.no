using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK 
    {
		public IKSolverAim solver = new IKSolverAim();
    }
}

