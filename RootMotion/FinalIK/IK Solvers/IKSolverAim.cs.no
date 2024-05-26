using UnityEngine;
using System.Collections;
using System;

namespace RootMotion.FinalIK
{

	[System.Serializable]
	public class IKSolverAim : IKSolverHeuristic {
        
		public Transform transform;
		public Vector3 axis = Vector3.forward;
		public Vector3 poleAxis = Vector3.up;
		public Vector3 polePosition;
		public float poleWeight;
        
		public Transform poleTarget;
		public float clampWeight = 0.1f;
		public int clampSmoothing = 2;
    }
}
