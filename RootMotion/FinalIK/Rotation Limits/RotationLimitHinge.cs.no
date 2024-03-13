using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit 
    {
		public bool useLimits = true;
		public float min = -45;
		public float max = 90;
        public float zeroAxisDisplayOffset;
	}
}
