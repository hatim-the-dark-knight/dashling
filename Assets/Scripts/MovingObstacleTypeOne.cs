using UnityEngine;

public class MovingObstacleTypeOne : MonoBehaviour
{
    public Transform[] waypoints;
    public float mo_speed;
    int current_index;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[0].position;
        current_index++;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position == waypoints[current_index].position)
            current_index++;
        if (current_index >= waypoints.Length)
            current_index = 0;
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current_index].position, mo_speed);
    }
}
