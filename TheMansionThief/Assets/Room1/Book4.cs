using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book4 : MonoBehaviour
{
    public GameObject targetObject; // ������ ������Ʈ�� �����ϱ� ���� ����

    private ButtonClick ButtonClick; // Ÿ�� ������Ʈ�� ����� BoolSequenceExample ��ũ��Ʈ�� ������ ����

    private bool isMouseOver = false;

    private void Start()
    {
        if (targetObject != null)
        {
            ButtonClick = targetObject.GetComponent<ButtonClick>();
        }
    }

    void Update()
    {
        if (isMouseOver && Input.GetKeyDown(KeyCode.E))
        {
            ButtonClick.SomeMethod(4);
        }
    }

    void OnMouseEnter()
    {
        isMouseOver = true;
    }

    void OnMouseExit()
    {
        isMouseOver = false;
    }
}
