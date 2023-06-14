using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdQuest : MonoBehaviour
{
    public GameObject Ui;
    public GameObject Cursor;
    public GameObject another;
    public MouseEnter mouseEnter;
    public bool Uivisible;

    void Start(){
        mouseEnter = GetComponent<MouseEnter>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&&mouseEnter.isMouseOver){
            ToggleUi();
        }
    }
    void ToggleUi(){
        Uivisible = !Uivisible;
        Ui.SetActive(Uivisible);
        Cursor.SetActive(!Uivisible);
        another.SetActive(!Uivisible);
    }
}
