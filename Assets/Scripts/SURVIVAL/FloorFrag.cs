using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorFrag : MonoBehaviour
{
    FloorSpawner floorSpawner;
    // Start is called before the first frame update
    void Start()
    {
        floorSpawner = GameObject.FindObjectOfType<FloorSpawner>();
        SpawnObstacles();
    }

    private void OnTriggerExit(Collider other)
    {
        floorSpawner.SpawnFloor();
        Destroy(gameObject, 3);
    }

    public GameObject obstacle;

    public void SpawnObstacles()
    {
        int spawnpnt = Random.Range(2, 5);
        Transform spawnpntpos = transform.GetChild(spawnpnt);

        Instantiate(obstacle, spawnpntpos.position, Quaternion.identity, transform);
    }
}
