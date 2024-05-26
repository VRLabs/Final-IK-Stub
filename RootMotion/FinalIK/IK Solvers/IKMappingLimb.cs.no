using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKMappingLimb: IKMapping 
    {
        [System.Serializable]
		public enum BoneMapType {
			Parent,
			Bone1,
			Bone2,
			Bone3
		}
        
		public Transform parentBone;
		public Transform bone1;
		public Transform bone2;
		public Transform bone3;
		public float maintainRotationWeight;
		public float weight = 1f;
    }
}
