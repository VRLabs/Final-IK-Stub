using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	[System.Serializable]
	public class IKSolverLimb : IKSolverTrigonometric 
    {
        public AvatarIKGoal goal;
		public BendModifier bendModifier;
		public float maintainRotationWeight;
		public float bendModifierWeight = 1f;
		public Transform bendGoal;

		[System.Serializable]
		public enum BendModifier {
			Animation,
			Target,
			Parent,
			Arm,
			Goal
		}
        
		[System.Serializable]
		public struct AxisDirection 
        {
			public Vector3 direction;
			public Vector3 axis;
			public float dot;
			
			public AxisDirection(Vector3 direction, Vector3 axis) {
				this.direction = direction.normalized;
				this.axis = axis.normalized;
				this.dot = 0;
			}
		}
		
		public IKSolverLimb() {}
        public IKSolverLimb(AvatarIKGoal goal) { this.goal = goal; }
		

	}
}
