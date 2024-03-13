using UnityEngine;
using System.Collections;
using UnityEngine.Events;

namespace RootMotion.FinalIK {

	public partial class IKSolverVR: IKSolver {

		[System.Serializable]
		public class Footstep 
        {
            public float stepSpeed = 3f;
			public Vector3 characterSpaceOffset;
            public Vector3 position;
			public Quaternion rotation = Quaternion.identity;
			public Quaternion stepToRootRot = Quaternion.identity;
			public bool isSupportLeg;
            public Vector3 stepFrom;
			public Vector3 stepTo;
			public Quaternion stepFromRot = Quaternion.identity;
			public Quaternion stepToRot = Quaternion.identity;
        }
	}
}
