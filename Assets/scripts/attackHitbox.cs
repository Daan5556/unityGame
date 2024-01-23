using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackHitbox : MonoBehaviour
{
    private CircleCollider2D hitboxCollider;
    public playerHealth PlayerHealth;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        hitboxCollider = GetComponentInChildren<CircleCollider2D>();
        // Deactivate the hitbox at the start
        deactivateHitbox();
    }

    public void activateHitbox()
    {
        hitboxCollider.enabled = true;
    }

    public void deactivateHitbox()
    {
        hitboxCollider.enabled = false;
    }

    public void changeHitboxSize()
    {
        hitboxCollider.radius = 0.93F;
    }

    public void resetHitboxSize()
    {
        hitboxCollider.radius = 0.84F;
    }
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemyHitbox"))
        {
            PlayerHealth.changeHealth(-25);
            animator.SetTrigger("hit");
        }
    }
}