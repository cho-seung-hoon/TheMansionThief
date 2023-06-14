using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    public float sensitivity = 2f; // 마우스 감도

    private float rotationX = 0f; // X축 회전 각도
    private float rotationY = 0f; // Y축 회전 각도

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !(isPause);
        }
        if(isPause)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        } else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            float mouseX = Input.GetAxis("Mouse X") * sensitivity; // 마우스 X 축 이동량
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity; // 마우스 Y 축 이동량

            rotationX -= mouseY; // Y 축 회전 각도 계산
            rotationY += mouseX; // X 축 회전 각도 계산
            rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Y 축 회전 각도 제한

            rotationY %= 180f; // X 축 회전 각도 제한 (0~180도 사이로 유지)

            Quaternion camRotation = Quaternion.Euler(rotationX, rotationY, 0f); // 카메라 회전 각도 계산

            // 카메라 회전 적용
            transform.localRotation = camRotation;
        }
       


    }
}
