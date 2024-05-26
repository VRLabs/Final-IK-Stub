using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK
{
    public class TwistRelaxer : MonoBehaviour
    {
        public IK ik;
        public Transform parent;
        public Transform child;
        public float weight = 1f;
        public float parentChildCrossfade = 0.5f;
        public float twistAngleOffset;
    }
}