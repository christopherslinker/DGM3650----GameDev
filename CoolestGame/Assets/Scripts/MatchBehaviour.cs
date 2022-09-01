using System;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idOBJ;
    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<IDContainerBehaviour>().idObj;
        if (otherID == idOBJ)
        {
            Debug.Log("Matched");
        }
    }
}
