using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackHitbox : MonoBehaviour
{
    private CircleCollider2D hitboxCollider;
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

    private void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Hit logic
        }
    }
}