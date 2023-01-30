using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclesPrefab;

    private Vector3 spawnPos = new Vector3(25, 0, -2);

    private float startDelay = 2;

    private float repeatMinxDelay = 1;
    private float repeatMaxDelay = 6;
    private PlayerController playerControllerScript;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, Random.Range(repeatMinxDelay, repeatMaxDelay));
        playerControllerScript =  GameObject.Find("DudeGuy").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclesPrefab, spawnPos, obstaclesPrefab.transform.rotation);
        }
    }
}