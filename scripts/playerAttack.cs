using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            animator.SetTrigger("attack");
        }
    }
    public void AnimationFinished()
    {
        animator.SetTrigger("ReturnToIdleTrigger");
    }
}