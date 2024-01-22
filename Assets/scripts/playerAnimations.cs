using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class playerAnimations : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rigidbody2d;

    private AttackState currentAttackState = AttackState.none;
    public enum AttackState
    {
        none,
        attack2,
        attack3
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // run
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0f)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
        // jump & fall
        float yVelocity = rigidbody2d.velocity.y;
        animator.SetFloat("Yvelocity", yVelocity);
        if (rigidbody2d.velocity.y == 0)
        {
            animator.SetTrigger("isGrounded");
        }
        // attack
        if (Input.GetMouseButtonDown(0) && currentAttackState == AttackState.none)
        {
            startAttack(AttackState.attack3);
        }


    }

    void startAttack(AttackState attackState)
    {
        currentAttackState = attackState;
        animator.SetInteger("AttackState", (int)currentAttackState);
    }

    void StopAttack()
    {
        currentAttackState = AttackState.none;
        animator.SetInteger("AttackState", (int)currentAttackState);
    }
}
