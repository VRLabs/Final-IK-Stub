using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK 
{
	[System.Serializable]
	public class IKMapping 
    {
        [System.Serializable]
		public class BoneMap {
			public Transform transform;
            public int chainIndex = -1;
			public int nodeIndex = -1;
            public Vector3 defaultLocalPosition;
			public Quaternion defaultLocalRotation;
			public Vector3 localSwingAxis, localTwistAxis, planePosition, ikPosition;
			public Quaternion defaultLocalTargetRotation;
			public float length;
			public Quaternion animatedRotation;
        }
    }
}
