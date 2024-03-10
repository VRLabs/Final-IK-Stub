using UnityEngine;
using System.Collections;
using System;
using RootMotion;

namespace RootMotion.FinalIK
{
    public partial class IKSolverVR : IKSolver
    {
        [System.Serializable]
        public class Arm : BodyPart
        {
            [System.Serializable]
            public enum ShoulderRotationMode
            {
                YawPitch,
                FromTo
            }

            public Transform target;
            public Transform bendGoal;
            public float positionWeight = 1f;
            public float rotationWeight = 1f;
            public ShoulderRotationMode shoulderRotationMode = ShoulderRotationMode.YawPitch;

            public float shoulderRotationWeight = 1f;
            public float shoulderTwistWeight = 1f;
            public float bendGoalWeight;
            public float swivelOffset;
            public Vector3 wristToPalmAxis = Vector3.zero;
            public Vector3 palmToThumbAxis = Vector3.zero;
            public float armLengthMlp = 1f;
            public AnimationCurve stretchCurve = new AnimationCurve();

        }
    }
}

