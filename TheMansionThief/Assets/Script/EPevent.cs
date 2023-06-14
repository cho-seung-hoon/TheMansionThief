using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPevent : MonoBehaviour
{
    public GameObject Cursor; // Cursor Ui 할당
    public GameObject another; // HoverText Ui 할당
    public GameObject Ui;
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
