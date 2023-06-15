using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class room4sc : MonoBehaviour
{
    public GameObject Current;
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI resultText;
    public int answer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clear4()
    {
        answer += 1;
        Debug.Log("1");
        if (answer == 3)
        {
            Print("Find The Fourth Hint");
        }
    }
    
    public void Print(string str){
        textComponent.text = str;
        resultText.text = "3";
        Current.SetActive(true);
        StartCoroutine(AfterDelay());
    }

    IEnumerator AfterDelay(){
        float delay = 3f;
        yield return new WaitForSeconds(delay);
        Current.SetActive(false);
    }
}
