using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idOBJ;
    public UnityEvent matchEvent, noMatchEvent;
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null) 
            return;
        
        var otherID = tempObj.idObj;
        if (otherID == idOBJ)
        {
            matchEvent.Invoke();
            Debug.Log("Match");
        }
        else
        {
           noMatchEvent.Invoke();
           Debug.Log("No Match");
        }
    }
}
