using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookClick : MonoBehaviour
{
    private Animator animator;
    private bool isMouseOver = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

   

    void Update()
    {
        if (isMouseOver && Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Open", true);
        }
    }

    void OnMouseEnter()
    {
        isMouseOver = true;
    }

    void OnMouseExit()
    {
        isMouseOver = false;
    }

}

