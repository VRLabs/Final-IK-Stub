using UnityEngine;
using System.Collections;
using System;
using RootMotion;

namespace RootMotion.FinalIK 
{
	public partial class IKSolverVR: IKSolver 
    {

		[System.Serializable]
		public enum PositionOffset {
			Pelvis,
			Chest,
			Head,
			LeftHand,
			RightHand,
			LeftFoot,
			RightFoot,
			LeftHeel,
			RightHeel
		}

		[System.Serializable]
		public enum RotationOffset {
			Pelvis,
			Chest,
			Head,
		}

		[System.Serializable]
		public class VirtualBone 
        {
            public Vector3 readPosition;
			public Quaternion readRotation;

			public Vector3 solverPosition;
			public Quaternion solverRotation;

			public float length;
			public float sqrMag;
			public Vector3 axis;
        }
	}
}

