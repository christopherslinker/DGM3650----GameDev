using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextLabelBehaviour : MonoBehaviour
{
    public Text label;
    public FloatData floatDataObj;


    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = floatDataObj.value.ToString();
    }
}
