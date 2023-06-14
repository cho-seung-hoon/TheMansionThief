using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuEvent : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject OptionMenu;
    public GameObject HintArea;
    public GameObject Cursor;
    private CameraController camerController;

    void Start(){
        camerController = Camera.main.GetComponent<CameraController>();
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
        camerController.ToggleCamera(true);
    }
    public void Pause(){
        Cursor.SetActive(false);
        OptionMenu.SetActive(true);
        GameIsPaused = true;
        camerController.ToggleCamera(false);
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
