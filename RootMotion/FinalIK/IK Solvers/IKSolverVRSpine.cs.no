using UnityEngine;
using System.Collections;
using System;
using RootMotion;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK 
{
	public partial class IKSolverVR: IKSolver
    {
		[System.Serializable]
		public class Spine: BodyPart
        {
            public Transform headTarget;
            public Transform pelvisTarget;
            public float positionWeight = 1f;
            public float rotationWeight = 1f;
            public float pelvisPositionWeight;
            public float pelvisRotationWeight;
            public Transform chestGoal;
            public float chestGoalWeight;
            public float minHeadHeight = 0.8f;
            public float bodyPosStiffness = 0.55f;
            public float bodyRotStiffness = 0.1f;
            [FormerlySerializedAs("chestRotationWeight")]
			public float neckStiffness = 0.2f;
            public float rotateChestByHands = 1f;
            public float chestClampWeight = 0.5f;
            public float headClampWeight = 0.6f;
            public float moveBodyBackWhenCrouching = 0.5f;
            public float maintainPelvisPosition = 0.2f;
            public float maxRootAngle = 25f;
            public float rootHeadingOffset;
        }
	}
}