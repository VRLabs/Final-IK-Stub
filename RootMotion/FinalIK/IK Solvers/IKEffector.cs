using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKEffector 
    {
        public Transform bone;
		public Transform target;
		public float positionWeight;
		public float rotationWeight;
		public Vector3 position = Vector3.zero;
		public Quaternion rotation = Quaternion.identity;
		public Vector3 positionOffset;
		public bool effectChildNodes = true;
		public float maintainRelativePositionWeight;
        public Transform[] childBones = new Transform[0];
		public Transform planeBone1;
		public Transform planeBone2;
		public Transform planeBone3;
		public Quaternion planeRotationOffset = Quaternion.identity;

		public IKEffector() {}
		
		public IKEffector (Transform bone, Transform[] childBones) 
        {
			this.bone = bone;
			this.childBones = childBones;
		}
    }
}