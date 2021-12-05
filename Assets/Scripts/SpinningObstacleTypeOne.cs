using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObstacleTypeOne : MonoBehaviour
{
    public float rot_velocity;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.up, rot_velocity);
    }
}
