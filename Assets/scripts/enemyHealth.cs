using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float enemyHealthAmount;
    public float enemyHealthMax = 100;
    public Animator enemy;
    public GameObject enemyObject;
    private BoxCollider2D enemyBoxCollider2D;
    private Rigidbody2D enemyRigidBody2D;


    // Start is called before the first frame update
    void Start()
    {
        enemyHealthAmount = enemyHealthMax;
        enemy = GetComponent<Animator>();
        enemyBoxCollider2D = GetComponent<BoxCollider2D>();
        enemyRigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("hitbox"))
        {
            enemy.SetTrigger("hit");
        }
    }

    public void AnimationFinished()
    {
        enemy.SetTrigger("ReturnToIdleTrigger");
    }

    public void die()
    {
        enemy.SetTrigger("die");
        enemyBoxCollider2D.enabled = false;
        enemyRigidBody2D.isKinematic = true;
    }

    public void died()
    {
        enemy.SetTrigger("died");
      
    }
}
