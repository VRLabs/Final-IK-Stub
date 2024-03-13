using UnityEngine;
using System.Collections;
using System;

namespace RootMotion.FinalIK 
{
	[System.Serializable]
	public enum FullBodyBipedEffector {
		Body,
		LeftShoulder,
		RightShoulder,
		LeftThigh,
		RightThigh,
		LeftHand,
		RightHand,
		LeftFoot,
		RightFoot
	}
    
	[System.Serializable]
	public enum FullBodyBipedChain {
		LeftArm,
		RightArm,
		LeftLeg,
		RightLeg
	}
    
	[System.Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody {
        
		public Transform rootNode;
		public float spineStiffness = 0.5f;
		public float pullBodyVertical = 0.5f;
		public float pullBodyHorizontal = 0f;
        public Vector3 pullBodyOffset { get; private set; }
    }
}
