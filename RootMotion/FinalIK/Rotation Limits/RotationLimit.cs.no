using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK
{
    public abstract class RotationLimit : MonoBehaviour
    {
        public Vector3 axis = Vector3.forward;
        public Quaternion defaultLocalRotation;
    }
}
