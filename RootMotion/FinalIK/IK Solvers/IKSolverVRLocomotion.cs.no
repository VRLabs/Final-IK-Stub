using UnityEngine;
using System.Collections;
using UnityEngine.Events;

namespace RootMotion.FinalIK {
	public partial class IKSolverVR: IKSolver 
    {

		[System.Serializable]
		public class Locomotion 
        {
            public float weight = 1f;
            public float footDistance = 0.3f;
            public float stepThreshold = 0.4f;
            public float angleThreshold = 60f;
            public float comAngleMlp = 1f;
            public float maxVelocity = 0.4f;
            public float velocityFactor = 0.4f;
			public float maxLegStretch = 1f;
            public float rootSpeed = 20f;
            public float stepSpeed = 3f;
            public AnimationCurve stepHeight;
            public AnimationCurve heelHeight;
            public float relaxLegTwistMinAngle = 20f;
            public float relaxLegTwistSpeed = 400f;
            public InterpolationMode stepInterpolation = InterpolationMode.InOutSine;
            public Vector3 offset;
            public bool blockingEnabled;
            public LayerMask blockingLayers;
            public float raycastRadius = 0.2f;
            public float raycastHeight = 0.2f;
            public UnityEvent onLeftFootstep = new UnityEvent();
            public UnityEvent onRightFootstep = new UnityEvent(); }
	}
}