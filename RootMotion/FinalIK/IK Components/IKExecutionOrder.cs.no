using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	public class IKExecutionOrder : MonoBehaviour 
    {
		public IK[] IKComponents;
        public Animator animator;
        private bool fixedFrame;
    }
}
