using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdHint : MonoBehaviour
{
    public GameObject Cursor; // Cursor Ui 할당
    public GameObject another; // HoverText Ui 할당
    public MouseEnter mouseEnter; // 현재 오브젝트 할당
    public MenuEvent menuEvent; // MainCamera > Ui 할당

    void Start()
    {
        mouseEnter = GetComponent<MouseEnter>();
        menuEvent = GetComponent<MenuEvent>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&&mouseEnter.isMouseOver){
            menuEvent.Print("Find The Third Hint");
        }
    }
}
