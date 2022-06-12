using UnityEngine;
using System.Collections;
using System;

namespace RootMotion {
	[System.Serializable]
	public class BipedReferences 
    {
        public Transform root;
		public Transform pelvis;
		public Transform leftThigh;
		public Transform leftCalf;
		public Transform leftFoot;
		public Transform rightThigh;
		public Transform rightCalf;
		public Transform rightFoot;
		public Transform leftUpperArm;
		public Transform leftForearm;
		public Transform leftHand;
		public Transform rightUpperArm;
		public Transform rightForearm;
		public Transform rightHand;
		public Transform head;
		public Transform[] spine = new Transform[0];
		public Transform[] eyes = new Transform[0];
    }
}
