using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEvent : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject OptionMenu;
    public GameObject HintArea;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Resume(){
        OptionMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause(){
        OptionMenu.SetActive(true);
        Time.timeScale = 0f;
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
}
