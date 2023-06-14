using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private void Start()
    {
     
    }

    private bool isColliding = false;
    public float speed = 2f; // �̵� �ӵ�

    private void Update()
    {
        if (!isColliding) { 
            float moveHorizontal = Input.GetAxis("Horizontal"); // ���� �̵� �Է�(-1: A, 1: D)
            float moveVertical = Input.GetAxis("Vertical"); // ���� �̵� �Է�(-1: S, 1: W)
                                                        // ī�޶��� ���� ���� ��������
            Vector3 cameraForward = Camera.main.transform.forward;
            cameraForward.y = 0f; // ���� ������ �̵��� ����

            // �Է°��� ī�޶��� ���� ���͸� ���Ͽ� �̵� ���� ����
            Vector3 movement = (moveVertical * cameraForward + moveHorizontal * Camera.main.transform.right).normalized;

            // �÷��̾� �̵�
            transform.Translate(movement * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // SŰ�� ������ �浹 ���¿��� ����������
            isColliding = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            isColliding = true; // �浹 ���� ����
            Debug.Log("Collision with Untagged object");
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            isColliding = false; // �浹 ���� ����
            Debug.Log("Collision with Untagged object ended");
        }
    }
}