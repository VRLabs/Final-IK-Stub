using UnityEngine;
using System.Collections;

	namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKConstraintBend 
    {
        public Transform bone1;
		public Transform bone2;
		public Transform bone3;
		public Transform bendGoal;
		public Vector3 direction = Vector3.right;
		public Quaternion rotationOffset;
		public float weight = 0f;

        public Vector3 defaultLocalDirection, defaultChildDirection;

		public IKConstraintBend() {}
		
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3) 
        {
            this.bone1 = bone1;
            this.bone2 = bone2;
            this.bone3 = bone3;
		}
    }
}
