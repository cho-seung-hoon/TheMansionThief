using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book3 : MonoBehaviour
{
    public GameObject targetObject; // 변경할 오브젝트를 연결하기 위한 변수

    private ButtonClick ButtonClick; // 타겟 오브젝트에 연결된 BoolSequenceExample 스크립트를 저장할 변수

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
            ButtonClick.SomeMethod(3); // 변경하고자 하는 스크립트의 변수 값을 변경합니다.
        }
    }
}
