using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public Vector2 position, offset;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        draggable = true;

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition);
            transform.position = position;
            Debug.Log("Drag");
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        Debug.Log("Stop Drag");
    }
}
