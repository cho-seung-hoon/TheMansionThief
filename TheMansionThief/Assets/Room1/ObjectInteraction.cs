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
                // 오브젝트를 B 오브젝트의 자식으로 설정
                transform.SetParent(bObject.transform);

                // 오브젝트의 위치를 마우스 커서의 위치로 설정
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = transform.position.z - mainCamera.transform.position.z;
                transform.position = mainCamera.ScreenToWorldPoint(mousePosition);

                // 오브젝트의 로컬 회전을 초기화
                transform.localRotation = Quaternion.identity;

                isFollowing = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            isFollowing = false;
            // 오브젝트의 부모를 null로 설정하여 자식 오브젝트에서 해제
            transform.SetParent(null);
        }

        if (isFollowing)
        {
            // 오브젝트를 메인 카메라 위치로 이동
            transform.position = mainCamera.transform.position;
        }
    }
}

