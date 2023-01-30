using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }
    
    void Update()
    {
        if (transform.position.x < startPos.x - 34.1)
        {
            transform.position = startPos;
        }
    }
}