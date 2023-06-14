using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookClick : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        animator.SetBool("Open", true);
        
    }

}

