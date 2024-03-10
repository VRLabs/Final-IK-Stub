using UnityEngine;
using System.Collections;
using System;
using RootMotion;

namespace RootMotion.FinalIK 
{
	public partial class IKSolverVR: IKSolver 
    {
		[System.Serializable]
		public abstract class BodyPart 
        {
            public VirtualBone[] bones = new VirtualBone[0];
        }
	}
}