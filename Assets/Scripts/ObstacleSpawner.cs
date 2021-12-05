using UnityEngine;

public class ObstacleSpawner: MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform[] spawn_point;
    public Rigidbody player;
    public Transform offset;
    public void SpawnObstacles()
    {
        int spawnpnt = Random.Range(0, 3);
        int x = Random.Range(0, obstacles.Length);
        if(x != 2 && x !=3)
            Instantiate(obstacles[x], spawn_point[spawnpnt].position, Quaternion.identity);
        else
            Instantiate(obstacles[x], spawn_point[1].position, Quaternion.identity);

    }

    private void Update()
    {
        
        for(int i = 0; i < spawn_point.Length; i++)
        {
            Vector3 temp = new Vector3(player.position.x + offset.transform.position.x, 0, spawn_point[i].position.z);
            spawn_point[i].position = temp;
        }
    }
}
