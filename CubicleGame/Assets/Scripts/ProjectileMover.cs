
using UnityEngine;

public class ProjectileMover : MonoBehaviour
{
    public float speed = 300.0f;
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}