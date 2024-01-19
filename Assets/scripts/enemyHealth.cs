using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float enemyHealthAmount;
    public float enemyHealthMax = 100;
    public Animator enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealthAmount = enemyHealthMax;
        enemy = GetComponent<Animator>();
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
}
