using System.Globalization;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int total;

    public void UpdateValue(int num)
    {
        total += num;
    }
}
