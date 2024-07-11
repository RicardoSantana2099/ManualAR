using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTouch : MonoBehaviour
{
    public float rotationSpeed = 2.0f;
    private bool isRotating = false;

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
                {
                if(hit.transform == transform)
                {
                    if(touch.phase == TouchPhase.Began)
                    {
                        isRotating = true;
                    }
                    else if (touch.phase == TouchPhase.Moved && isRotating)
                    {
                        float deltaX = touch.deltaPosition.x * rotationSpeed;
                        float deltaY = touch.deltaPosition.y * rotationSpeed;

                        transform.Rotate(Vector3.up, -deltaX, Space.World);
                        transform.Rotate(Vector3.right, deltaY, Space.World);
                    }
                    else if(touch.phase == TouchPhase.Ended)
                    {
                        isRotating= false;
                    }
                }
            }
        }
    }
}
