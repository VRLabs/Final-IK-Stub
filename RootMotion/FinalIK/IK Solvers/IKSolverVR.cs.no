using UnityEngine;
using System.Collections;
using System;
using RootMotion;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public partial class IKSolverVR: IKSolver 
    {
        public int LOD = 0;
        public bool plantFeet = true;
        public Spine spine = new Spine();
        public Arm leftArm = new Arm();
        public Arm rightArm = new Arm();
        public Leg leftLeg = new Leg();
        public Leg rightLeg = new Leg();
        public Locomotion locomotion = new Locomotion();
    }
}