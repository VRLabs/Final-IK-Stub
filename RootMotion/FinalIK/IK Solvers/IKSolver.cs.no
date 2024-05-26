using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {

	[System.Serializable]
	public abstract class IKSolver {
        
        public Vector3 IKPosition;
        public float IKPositionWeight = 1f;
        public bool initiated;

		[System.Serializable]
		public class Point {

			public Transform transform;
			public float weight = 1f;
			public Vector3 solverPosition;
			public Quaternion solverRotation = Quaternion.identity;
			public Vector3 defaultLocalPosition;
			public Quaternion defaultLocalRotation;
        }
        
        [System.Serializable]
		public class Bone: Point 
        {
            public float length;
			public float sqrMag;
			public Vector3 axis = -Vector3.right;
        }
		
		[System.Serializable]
		public class Node: Point 
        {
            public float length;
            public float effectorPositionWeight;
			public float effectorRotationWeight;
			public Vector3 offset;
        }
        
        [SerializeField] protected Transform root;
    }
}

