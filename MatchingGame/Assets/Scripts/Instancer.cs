using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;

    private int num = 0;
    
    public void CreateInstance()
    {
        Instantiate(prefab);
        
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreatInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vectro3List)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }
    
    
    public void CreatInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vectro3List[num].value, Quaternion.identity);
        num++;
        if (num == obj.vectro3List.Count)
        {
            num = 0;
        }
    }
    
    public void CreatInstanceListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vectro3List.Count - 1);
        Instantiate(prefab, obj.vectro3List[num].value, Quaternion.identity);
        
    }
}
