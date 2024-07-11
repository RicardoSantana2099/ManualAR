using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTouch : MonoBehaviour
{
    private Touch initialTouch = new Touch();
    private bool isRotating = false;
    public float rotationSpeed = 0.2f;

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch currentTouch = Input.GetTouch(0);

            switch(currentTouch.phase)
            {
                case TouchPhase.Began:
                    initialTouch = currentTouch;
                    isRotating = true;
                    break;

                    case TouchPhase.Moved:
                    if(isRotating)
                    {
                        float deltaX =  initialTouch.position.x - currentTouch.position.x;
                        float deltaY = initialTouch.position.y - currentTouch.position.y;
                        initialTouch = currentTouch;
                        transform.Rotate(Vector3.up, -deltaX * rotationSpeed, Space.World);
                        transform.Rotate(Vector3.right, deltaY * rotationSpeed, Space.World);
                    }
                    break;

                    case TouchPhase.Ended:
                    isRotating = false;
                    break;
            }
        }
    }
}
