using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	public class FBBIKHeadEffector : MonoBehaviour {

		public FullBodyBipedIK ik;
        public float positionWeight = 1f;
        public float bodyWeight = 0.8f;
        public float thighWeight = 0.8f;
        public bool handsPullBody = true;
        public float rotationWeight = 0f;
        public float bodyClampWeight = 0.5f;
        public float headClampWeight = 0.5f;
        public float bendWeight = 1f;
        public BendBone[] bendBones = new BendBone[0];
		
		[System.Serializable]
		public class BendBone 
        {
            public Transform transform;
            public float weight = 0.5f;
            public BendBone() {}

			public BendBone(Transform transform, float weight) {
				this.transform = transform;
				this.weight = weight;
			}
        }
        
        public float CCDWeight = 1f; 
        public float roll = 0f;
        public float damper = 500f;
        public Transform[] CCDBones = new Transform[0]; 
        public float postStretchWeight = 1f;
        public float maxStretch = 0.1f; 
        public float stretchDamper = 0f;
		public bool fixHead;
		public Transform[] stretchBones = new Transform[0];
        public Vector3 chestDirection = Vector3.forward;
		public float chestDirectionWeight = 1f;
		public Transform[] chestBones = new Transform[0];
    }
}
