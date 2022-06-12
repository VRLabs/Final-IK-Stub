using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	public class GrounderQuadruped: Grounder 
    {
        public Grounding forelegSolver = new Grounding();
		public float rootRotationWeight = 0.5f;
		public float minRootRotation = -25f;
		public float maxRootRotation = 45f;
		public float rootRotationSpeed = 5f;
		public float maxLegOffset = 0.5f;
		public float maxForeLegOffset = 0.5f;
		public float maintainHeadRotationWeight = 0.5f;
		public Transform characterRoot;
		public Transform pelvis;
		public Transform lastSpineBone;
		public Transform head;
		public IK[] legs;
		public IK[] forelegs;
		public Vector3 gravity = Vector3.down;
    }
}

