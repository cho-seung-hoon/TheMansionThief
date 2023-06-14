using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book4 : MonoBehaviour
{
    public GameObject targetObject; // 변경할 오브젝트를 연결하기 위한 변수

    private ButtonClick ButtonClick; // 타겟 오브젝트에 연결된 BoolSequenceExample 스크립트를 저장할 변수

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
