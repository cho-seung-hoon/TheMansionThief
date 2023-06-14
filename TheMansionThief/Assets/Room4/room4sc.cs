using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4sc : MonoBehaviour
{
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
            Debug.Log("romm4");
        }
    }
}
