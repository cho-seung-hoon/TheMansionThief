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

    public float sensitivity = 2f; // ���콺 ����

    private float rotationX = 0f; // X�� ȸ�� ����
    private float rotationY = 0f; // Y�� ȸ�� ����

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

            float mouseX = Input.GetAxis("Mouse X") * sensitivity; // ���콺 X �� �̵���
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity; // ���콺 Y �� �̵���

            rotationX -= mouseY; // Y �� ȸ�� ���� ���
            rotationY += mouseX; // X �� ȸ�� ���� ���
            rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Y �� ȸ�� ���� ����

            rotationY %= 180f; // X �� ȸ�� ���� ���� (0~180�� ���̷� ����)

            Quaternion camRotation = Quaternion.Euler(rotationX, rotationY, 0f); // ī�޶� ȸ�� ���� ���

            // ī�޶� ȸ�� ����
            transform.localRotation = camRotation;
        }
       


    }
}
