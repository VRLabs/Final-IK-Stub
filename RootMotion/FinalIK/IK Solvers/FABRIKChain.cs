using UnityEngine;
using System.Collections;

	namespace RootMotion.FinalIK {
	[System.Serializable]
	public class FABRIKChain 
    {
        public FABRIK ik;
		public float pull = 1f;
		public float pin = 1f;
		public int[] children = new int[0];
    }
}
