using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject bObject;

    private bool isFollowing = false;
    private bool isMouseOver = false;

    private void OnMouseEnter()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isMouseOver)
            {
                // ������Ʈ�� B ������Ʈ�� �ڽ����� ����
                transform.SetParent(bObject.transform);

                // ������Ʈ�� ��ġ�� ���콺 Ŀ���� ��ġ�� ����
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = transform.position.z - mainCamera.transform.position.z;
                transform.position = mainCamera.ScreenToWorldPoint(mousePosition);

                // ������Ʈ�� ���� ȸ���� �ʱ�ȭ
                transform.localRotation = Quaternion.identity;

                isFollowing = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            isFollowing = false;
            // ������Ʈ�� �θ� null�� �����Ͽ� �ڽ� ������Ʈ���� ����
            transform.SetParent(null);
        }

        if (isFollowing)
        {
            // ������Ʈ�� ���� ī�޶� ��ġ�� �̵�
            transform.position = mainCamera.transform.position;
        }
    }
}

