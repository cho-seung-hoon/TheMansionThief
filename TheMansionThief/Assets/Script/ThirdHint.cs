using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThirdHint : MonoBehaviour
{
    public GameObject Cursor; // Cursor Ui 할당
    public GameObject another; // HoverText Ui 할당
    public MouseEnter mouseEnter; // 현재 오브젝트 할당
    public MenuEvent menuEvent; // MainCamera > Ui 할당
    public GameObject Current;
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI resultText;

    void Start()
    {
        mouseEnter = GetComponent<MouseEnter>();
        menuEvent = GetComponent<MenuEvent>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&&mouseEnter.isMouseOver){
            Print("Find The Third Hint");
        }
    }
    public void Print(string str){
        textComponent.text = str;
        resultText.text = "2";
        Current.SetActive(true);
        StartCoroutine(AfterDelay());
    }

    IEnumerator AfterDelay(){
        float delay = 3f;
        yield return new WaitForSeconds(delay);
        Current.SetActive(false);
    }
}
