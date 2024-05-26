using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKMappingBone: IKMapping 
    {
        public Transform bone;
		public float maintainRotationWeight = 1f;

        public IKMappingBone() {}
		
		public IKMappingBone(Transform bone) 
        {
			this.bone = bone;
		}
    }
}
