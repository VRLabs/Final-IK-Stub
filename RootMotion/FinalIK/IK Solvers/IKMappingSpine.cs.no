using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKMappingSpine: IKMapping 
    {
        public Transform[] spineBones;
		public Transform leftUpperArmBone;
		public Transform rightUpperArmBone;
		public Transform leftThighBone;
		public Transform rightThighBone;
		public int iterations = 3;
		public float twistWeight = 1f;
		
		public IKMappingSpine() {}
		
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) {
            this.spineBones = spineBones;
            this.leftUpperArmBone = leftUpperArmBone;
            this.rightUpperArmBone = rightUpperArmBone;
            this.leftThighBone = leftThighBone;
            this.rightThighBone = rightThighBone;
        }
    }
}
