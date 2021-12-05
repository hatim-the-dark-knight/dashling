using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class CamFollowPlayer : MonoBehaviour
    {
        public Transform cam_destination;
 
        // Update is called once per frame
        void FixedUpdate()
        {
            transform.position = Vector3.Lerp(transform.position, cam_destination.position, Vector3.Distance(transform.position, cam_destination.position)/10);
        }
    }
}