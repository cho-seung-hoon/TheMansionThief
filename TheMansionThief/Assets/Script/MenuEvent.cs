using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuEvent : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject OptionMenu;
    public GameObject HintArea;
    public GameObject Cursor;
    public GameObject Current;
    public TextMeshProUGUI textComponent;
    

    void Start(){

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            }
            else{
                Pause();
                
            }
        }
    }
    public void Resume(){
        Cursor.SetActive(true);
        OptionMenu.SetActive(false);
        GameIsPaused = false;
    }
    public void Pause(){
        Cursor.SetActive(false);
        OptionMenu.SetActive(true);
        GameIsPaused = true;
    }
    public void Hint(){
        OptionMenu.SetActive(false);
        HintArea.SetActive(true);
    }
    public void Quit_hint(){
        HintArea.SetActive(false);
        OptionMenu.SetActive(true);
    }
    public void Quit(){
        Application.Quit();
    }

    public void Print(string str){
        textComponent.text = str;

        Current.SetActive(true);
        StartCoroutine(AfterDelay());
    }

    IEnumerator AfterDelay(){
        float delay = 3f;
        yield return new WaitForSeconds(delay);
        Current.SetActive(false);
    }
    
}
