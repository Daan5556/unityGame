using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float enemyHealthAmount;
    public float enemyHealthMax = 100;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealthAmount = enemyHealthMax;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("hitbox"))
        {
            Debug.Log("Collision");
        }
    }
}
