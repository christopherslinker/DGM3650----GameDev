using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : IDContainerBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayed;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null) 
            yield break;
        
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
           noMatchEvent.Invoke();
           yield return new WaitForSeconds(0.5f);
           noMatchDelayed.Invoke();
        }
    }
}
