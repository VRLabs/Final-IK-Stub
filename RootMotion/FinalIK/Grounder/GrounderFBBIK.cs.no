using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK: Grounder 
    {
        [System.Serializable]
		public class SpineEffector 
        {
			public FullBodyBipedEffector effectorType;
			public float horizontalWeight = 1f;
			public float verticalWeight;

			public SpineEffector() {}
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight) {
				this.effectorType = effectorType;
				this.horizontalWeight = horizontalWeight;
				this.verticalWeight = verticalWeight;
			}
		}
		public FullBodyBipedIK ik;
		public float spineBend = 2f;
		public float spineSpeed = 3f;
		public SpineEffector[] spine = new SpineEffector[0];
    }
}
