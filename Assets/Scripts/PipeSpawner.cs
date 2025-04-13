using UnityEngine;
using static UnityEngine.UI.Image;
using UnityEngine.UIElements;
using Unity.Mathematics;

public class PipeSpawner : MonoBehaviour
{
    public GameObject PipePrefabs;
    public float SpawnRate = 2f;
    public float TimeSinceLastTime = 0f;
    void Update()
    {
        if (Time.time - TimeSinceLastTime >= SpawnRate)
        {
            GameObject pipeprefabs = Instantiate(PipePrefabs,transform.position, quaternion.identity);
            TimeSinceLastTime = Time.time;
        }
    }
}
