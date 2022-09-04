using UnityEngine;

[CreateAssetMenu]
public partial class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }
}
