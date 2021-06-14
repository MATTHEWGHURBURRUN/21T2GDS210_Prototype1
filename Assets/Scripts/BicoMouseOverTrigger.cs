using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public GameObject bicoText;

public class MouseOverTrigger : MonoBehaviour
{
    public Animator animator;

    public void Start()
    {
        bicoText.SetActive(false);
        animator = this.GetComponent<Animator>();
    }
    void OnMouseEnter() 
    {
        Debug.Log("Something");
        bicoText.SetActive(true);
        animator.SetBool("MouseOver", true);
    }
    void OnMouseExit() 
    {
        bicoText.SetActive(false);
        animator.SetBool("MouseOver", false);
    }
}

