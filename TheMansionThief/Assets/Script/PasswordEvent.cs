using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordEvent : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI currentText;

    public GameObject resultUi;

    string answer = "2023";
    string currentStr = "";

    public void ButtonClick(string value){
        currentStr += value;
        currentText.text = currentStr;
    }

    public void Delete(){
        if(currentStr.Length > 0){
            currentStr = currentStr.Substring(0, currentStr.Length - 1);
            currentText.text = currentStr;
        }
    }
    public void Confirm(){
        if(currentStr == answer){
            resultText.text = "Correct!";
            resultUi.SetActive(true);
            StartCoroutine(AfterDelay());
            StartCoroutine(AfterEnd());
        }
        else{
            resultText.text = "Not Answer";
            resultUi.SetActive(true);
            StartCoroutine(AfterDelay());
        }
    }
    IEnumerator AfterDelay(){
        float delay = 3f;
        yield return new WaitForSeconds(delay);
        resultUi.SetActive(false);
    }
    IEnumerator AfterEnd(){
        float delay = 3f;
        yield return new WaitForSeconds(delay);
        Application.Quit();
    }
}
