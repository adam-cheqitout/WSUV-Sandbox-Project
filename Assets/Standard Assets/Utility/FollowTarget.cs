using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);
        public float smooth = 1;

        private void LateUpdate()
        {
            
            Quaternion targetRotation = Quaternion.Euler(target.rotation.x, 0, target.rotation.z);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * smooth);
            transform.position = target.position + offset;
            
        }
    }
}
