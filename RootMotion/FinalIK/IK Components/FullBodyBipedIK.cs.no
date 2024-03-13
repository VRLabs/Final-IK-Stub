using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK 
    {
        public BipedReferences references = new BipedReferences();
		public IKSolverFullBodyBiped solver = new IKSolverFullBodyBiped();
    }
}
