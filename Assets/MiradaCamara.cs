using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiradaCamara : MonoBehaviour
{

    public Vector2 sensibility;
    public new Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = transform.Find("Camera");
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");

        if(MouseX != 0)
        {
            transform.Rotate(Vector3.up * MouseX * sensibility.x);
        }

        if (MouseY != 0)
        {
            float angle = (camera.localEulerAngles.x - MouseY * sensibility.y + 360) % 360;
            if(angle > 100)
            {
                angle -= 360;
            }
            angle = Mathf.Clamp(angle, -80, 80);
            camera.localEulerAngles = Vector3.right * angle;
        }
      

    }
}
