using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private Animator animator;
    public playerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            animator.SetTrigger("attack");
        }

        if (Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("attackHeavy");
        }
    }
    public void AnimationFinished()
    {
        animator.SetTrigger("ReturnToIdleTrigger");
    }

    public void slowMovement()
    {
        playerMovement.moveSpeed = 1f;
        playerMovement.jumpForce = 3f;
    }

    public void resetMovement()
    {
        playerMovement.moveSpeed = 5f;
        playerMovement.jumpForce = 5f;
    }


}