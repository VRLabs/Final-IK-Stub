using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKSolverLookAt : IKSolver 
    {
        public Transform target;
		public LookAtBone[] spine = new LookAtBone[0];
		public LookAtBone head = new LookAtBone();
		public LookAtBone[] eyes = new LookAtBone[0];
		public float bodyWeight = 0.5f;
		public float headWeight = 0.5f;
		public float eyesWeight = 1f;
		public float clampWeight = 0.5f;
		public float clampWeightHead = 0.5f;
		public float clampWeightEyes = 0.5f;
		public int clampSmoothing = 2;
		public AnimationCurve spineWeightCurve = new AnimationCurve(new Keyframe[2] { new Keyframe(0f, 0.3f), new Keyframe(1f, 1f) });
		public Vector3 spineTargetOffset;
		
		[System.Serializable]
		public class LookAtBone: IKSolver.Bone 
        {
            public Vector3 baseForwardOffsetEuler;
            public LookAtBone() {}
			public LookAtBone(Transform transform) { this.transform = transform; }
        }
    }
}
