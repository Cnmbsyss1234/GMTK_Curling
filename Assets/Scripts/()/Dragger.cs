using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    bool drag;
    private void OnMouseDown()
    {
        drag = true;
    }
    private void OnMouseUp()
    {
        drag = false;
    }

    private void Update()
    {
        if (drag)
        {
            transform.position = GetMousePos();
            Vector3 GetMousePos()
            {
                var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                return mousePos;
            }
        }
        
    }

}
