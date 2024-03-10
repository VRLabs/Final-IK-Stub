using UnityEngine;
using System.Collections;
using System;
using RootMotion;

namespace RootMotion.FinalIK {
	public partial class IKSolverVR: IKSolver 
    {
		[System.Serializable]
		public class Leg: BodyPart 
        {

            public Transform target;
            public Transform bendGoal;
            public float positionWeight;
            public float rotationWeight;
            public float bendGoalWeight; 
            public float swivelOffset;
            public float bendToTargetWeight = 0.5f;
            public float legLengthMlp = 1f;
            public AnimationCurve stretchCurve = new AnimationCurve();
            public bool useAnimatedBendNormal;
        }
	}
}