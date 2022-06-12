using UnityEngine;
using System.Collections;
using System;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKSolverHeuristic: IKSolver {
        public Transform target;
		public float tolerance = 0f;
		public int maxIterations = 4;
		public bool useRotationLimits = true;
		public bool XY;
		public Bone[] bones = new Bone[0];

		protected Vector3 lastLocalDirection;
		protected float chainLength;
    }
}
