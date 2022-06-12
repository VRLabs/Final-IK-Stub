using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK 
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit 
    {
        public float twistLimit = 180;
		public int smoothIterations = 0;
		
		[System.Serializable]
		public class ReachCone 
        {
			public Vector3[] tetrahedron;
			public float volume;
			public Vector3 S, B;
            public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c) 
            {
				this.tetrahedron = new Vector3[4];
				this.tetrahedron[0] = _o;
				this.tetrahedron[1] = _a;
				this.tetrahedron[2] = _b;
				this.tetrahedron[3] = _c;
				
				this.volume = 0;
				this.S = Vector3.zero;
				this.B = Vector3.zero;
			}
        }
        
		[System.Serializable]
		public class LimitPoint 
        {
			public Vector3 point;
			public float tangentWeight;
			
			public LimitPoint() 
            {
				this.point = Vector3.forward;
				this.tangentWeight = 1;
			}
		}
		
		public LimitPoint[] points;
		public Vector3[] P;
		public ReachCone[] reachCones = new ReachCone[0];
    }
}
