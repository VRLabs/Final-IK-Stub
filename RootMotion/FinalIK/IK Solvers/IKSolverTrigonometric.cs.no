using UnityEngine;
using System.Collections;
using System;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKSolverTrigonometric: IKSolver 
    {
        public Transform target;
		public float IKRotationWeight = 1f;
		public Quaternion IKRotation = Quaternion.identity;
		public Vector3 bendNormal = Vector3.right;
		public TrigonometricBone bone1 = new TrigonometricBone();
		public TrigonometricBone bone2 = new TrigonometricBone();
		public TrigonometricBone bone3 = new TrigonometricBone();
		
		[System.Serializable]
		public class TrigonometricBone: IKSolver.Bone { }
    }
}
		
