using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    bool isCameraMove = true;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public float sensitivity = 2f;

    private float rotationX = 0f;
    private float rotationY = 0f;

    private void Update()
    {
        if(isCameraMove)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            rotationX -= mouseY;
            rotationY += mouseX;
            rotationX = Mathf.Clamp(rotationX, -90f, 90f);

            rotationY %= 180f;

            Quaternion camRotation = Quaternion.Euler(rotationX, rotationY, 0f);

            transform.localRotation = camRotation;
        }
    }

    public void ToggleCamera(bool isEnabled){
        isCameraMove = isEnabled;
        Cursor.visible = !isEnabled;

        if(isEnabled){
            Cursor.lockState = CursorLockMode.Locked;
        }
        else{
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
