using UnityEngine;
using System.Collections;
using System;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class FBIKChain 
    {
        [System.Serializable]
		public class ChildConstraint 
        {
			public float pushElasticity = 0f;
			public float pullElasticity = 0f;
			[SerializeField] private Transform bone1;
			[SerializeField] private Transform bone2;
			private float crossFade, inverseCrossFade;
        }

		[System.Serializable]
		public enum Smoothing 
        {
			None,
			Exponential,
			Cubic
		}
        
		public float pin;
		public float pull = 1f;
		public float push;
		public float pushParent;
		public float reach = 0.1f;
		public Smoothing reachSmoothing = Smoothing.Exponential;
		public Smoothing pushSmoothing = Smoothing.Exponential;
		public IKSolver.Node[] nodes = new IKSolver.Node[0];
		public int[] children = new int[0];
		public ChildConstraint[] childConstraints = new ChildConstraint[0];
		public IKConstraintBend bendConstraint = new IKConstraintBend();

        public FBIKChain() {}
		
		public FBIKChain (float pin, float pull, params Transform[] nodeTransforms) {
			this.pin = pin;
			this.pull = pull;
            
			children = new int[0];
		}
    }
}