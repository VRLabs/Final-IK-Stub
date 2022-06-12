using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit 
    {
        public float limit = 45;
		public float twistLimit = 180;
    }
}
