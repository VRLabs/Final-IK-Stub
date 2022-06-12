using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKSolverFullBody : IKSolver 
    {
		public int iterations = 4;
		public FBIKChain[] chain = new FBIKChain[0];
		public IKEffector[] effectors = new IKEffector[0];
		public IKMappingSpine spineMapping = new IKMappingSpine();
		public IKMappingBone[] boneMappings = new IKMappingBone[0];
		public IKMappingLimb[] limbMappings = new IKMappingLimb[0];
		public bool FABRIKPass = true;
    }
}
