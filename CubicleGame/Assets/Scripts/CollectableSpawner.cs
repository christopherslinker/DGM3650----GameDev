
using UnityEngine;
using Random = UnityEngine.Random;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject collectable;
    
    private float ySpawn = 0.75f;
    
    private float xSpawnRange = 480.0f;

    private float zSpawnRange = 238.0f;

    private float startDelay = 5.0f;

    private float collectableSpawnTime = 3.0f;

    //public GameOverBehaviour gameOverBehaviour;

    void Start()
    {        
        InvokeRepeating("SpawnCollectable", startDelay, collectableSpawnTime);
        //gameOverBehaviour = GameObject.Find("GameOverBehaviour").GetComponent<GameOverBehaviour>();
    }

    void SpawnCollectable()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zSpawnRange, zSpawnRange);
    
        var spawnPos = new Vector3(randomX, ySpawn, randomZ);
        Instantiate(collectable, spawnPos, collectable.gameObject.transform.rotation);
        
        
        /*if (!gameOverBehaviour.gameIsOver)
        {
            float randomX = Random.Range(-xSpawnRange, xSpawnRange);
            float randomZ = Random.Range(-zSpawnRange, zSpawnRange);
    
            var spawnPos = new Vector3(randomX, ySpawn, randomZ);
            Instantiate(collectable, spawnPos, collectable.gameObject.transform.rotation);
        }*/

    }
    
    
}