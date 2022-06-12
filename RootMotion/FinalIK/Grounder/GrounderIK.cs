using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	public class GrounderIK: Grounder 
    {
        public IK[] legs;
		public Transform pelvis;
		public Transform characterRoot;
		public float rootRotationWeight;
		public float rootRotationSpeed = 5f;
		public float maxRootRotationAngle = 45f;
    }
}
