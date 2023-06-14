using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    bool isCameraMove = true;


    public Transform cubeTransform;

    public float sensitivity = 2f;

    private float rotationX = 0f;
    private float rotationY = 0f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        if(isCameraMove)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            rotationX -= mouseY;
            rotationY += mouseX;
            rotationX = Mathf.Clamp(rotationX, -90f, 90f);
            rotationY %= 360f;

            Quaternion camRotation = Quaternion.Euler(rotationX, rotationY, 0f);
            transform.localRotation = camRotation;

            Quaternion cubeRotation = Quaternion.Euler(rotationX, rotationY, 0f); // 큐브를 Y축을 기준으로 회전시키기 위한 회전 값 계산
            cubeTransform.localRotation = cubeRotation;
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
