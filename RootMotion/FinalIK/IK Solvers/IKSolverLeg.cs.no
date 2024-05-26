using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK 
{
	[System.Serializable]
	public class IKSolverLeg : IKSolver 
    {
        public float IKRotationWeight = 1f;
		public Quaternion IKRotation = Quaternion.identity;
        public IKSolver.Point pelvis = new IKSolver.Point();
		public IKSolver.Point thigh = new IKSolver.Point();
		public IKSolver.Point calf = new IKSolver.Point();
		public IKSolver.Point foot = new IKSolver.Point();
		public IKSolver.Point toe = new IKSolver.Point();
        public IKSolverVR.Leg leg = new IKSolverVR.Leg();
		public Vector3 heelOffset;
    }
}