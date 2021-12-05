using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject floorFrag;
    Vector3 NextFloorSpawn;

    public void SpawnFloor()
    {
        GameObject spawned = Instantiate(floorFrag, NextFloorSpawn, Quaternion.identity);
        NextFloorSpawn = spawned.transform.GetChild(1).transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnFloor();
        SpawnFloor();
    }
}
