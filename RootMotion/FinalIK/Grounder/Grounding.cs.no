using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public partial class Grounding 
    {
        [System.Serializable]
		public enum Quality {
			Fastest,
			Simple,
			Best
		}
        
		public LayerMask layers;
		public float maxStep = 0.5f;
		public float heightOffset;
		public float footSpeed = 2.5f;
		public float footRadius = 0.15f;
		public float footCenterOffset;
		public float prediction = 0.05f;
		public float footRotationWeight = 1f;
		public float footRotationSpeed = 7f;
		public float maxFootRotationAngle = 45f;
		public bool rotateSolver;
		public float pelvisSpeed = 5f;
		public float pelvisDamper;
		public float lowerPelvisWeight = 1f;
		public float liftPelvisWeight;
		public float rootSphereCastRadius = 0.1f;
        public bool overstepFallsDown = true;
		public Quality quality = Quality.Best;
    }
}


