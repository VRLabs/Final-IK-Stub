using UnityEngine;
using System.Collections;
using RootMotion.FinalIK;

namespace RootMotion.FinalIK {
	public class FBBIKArmBending : MonoBehaviour {

		public FullBodyBipedIK ik;
		public Vector3 bendDirectionOffsetLeft;
		public Vector3 bendDirectionOffsetRight;
		public Vector3 characterSpaceBendOffsetLeft;
		public Vector3 characterSpaceBendOffsetRight;
    }
}
