using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK 
    {
        public IKSolverFABRIKRoot solver = new IKSolverFABRIKRoot();
    }
}
