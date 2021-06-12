using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOverTrigger : MonoBehaviour
{
    public Animator animator;

    void Start()
    { 
        animator = this.GetComponent<Animator>();
    }
    void OnMouseEnter() 
    {
        Debug.Log("Something");
        animator.SetBool("MouseOver", true);
    }
    void OnMouseExit() 
    {
        animator.SetBool("MouseOver", false);
    }
}

