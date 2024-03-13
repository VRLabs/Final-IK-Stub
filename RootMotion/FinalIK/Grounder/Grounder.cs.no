using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {
	public abstract class Grounder: MonoBehaviour 
    {
        public float weight = 1f;
		public Grounding solver = new Grounding();
    }
}

