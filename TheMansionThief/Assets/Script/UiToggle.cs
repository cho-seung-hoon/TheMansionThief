using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiToggle : MonoBehaviour
{
    public GameObject Ui;
    public GameObject Cursor;
    public GameObject another;
    public MouseEnter mouseEnter;
    private CameraController camerController;
    public bool Uivisible = false;

    void Start(){
        mouseEnter = GetComponent<MouseEnter>();
        camerController = Camera.main.GetComponent<CameraController>();
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
        camerController.ToggleCamera(!Uivisible);
    }
}
