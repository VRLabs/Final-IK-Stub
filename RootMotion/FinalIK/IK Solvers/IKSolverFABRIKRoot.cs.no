using UnityEngine;
using System.Collections;
using System;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKSolverFABRIKRoot : IKSolver 
    {
        public int iterations = 4;
		public float rootPin = 0f;
		public FABRIKChain[] chains = new FABRIKChain[0];
    }
}
