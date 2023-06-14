using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book3 : MonoBehaviour
{
    public GameObject targetObject; // ������ ������Ʈ�� �����ϱ� ���� ����

    private ButtonClick ButtonClick; // Ÿ�� ������Ʈ�� ����� BoolSequenceExample ��ũ��Ʈ�� ������ ����

    private void Start()
    {
        if (targetObject != null)
        {
            ButtonClick = targetObject.GetComponent<ButtonClick>();
        }
    }

    private void OnMouseDown()
    {
        if (ButtonClick != null)
        {
            ButtonClick.SomeMethod(3); // �����ϰ��� �ϴ� ��ũ��Ʈ�� ���� ���� �����մϴ�.
        }
    }
}
