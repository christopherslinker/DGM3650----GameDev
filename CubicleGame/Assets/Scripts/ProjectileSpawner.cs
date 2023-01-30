
using UnityEngine;
using UnityEngine.Serialization;

public class ProjectileSpawner : MonoBehaviour
{
    [FormerlySerializedAs("asteroidPrefab")] public GameObject[] projectilePrefab;

    private float spawnRangeX = 480f;

    private float SpawnPosZ = 400f;

    private float startDelay = 2;

    public float startInterval = 3.0f;

    public float increaseSpeed = .5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomProjectile), startDelay, startInterval);
    }
    
    private void SpawnRandomProjectile ()
    {
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, SpawnPosZ);
                
        int projectileIndex = Random.Range(0, projectilePrefab.Length);
                
        Instantiate(projectilePrefab [projectileIndex], spawnPos,
            projectilePrefab [projectileIndex].transform.rotation);

        if (Time.deltaTime == 5)
        {
            startInterval = startInterval - increaseSpeed;
        }
    }
}