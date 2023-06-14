using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEnter : MonoBehaviour
{
    public GameObject hoverText;
    public bool isMouseOver = false;
    public void OnMouseEnter(){
        isMouseOver = true;
        hoverText.SetActive(true);
    }

    public void OnMouseExit(){
        isMouseOver = false;
        hoverText.SetActive(false);
    }
}
