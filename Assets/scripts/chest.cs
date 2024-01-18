using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    private Animator Chest;
    private BoxCollider2D boxCollider2D;
    public GameObject pickUpOrb;
    private SpriteRenderer spriteRenderer;
    public float fadeInDuration = 2F;
    // Start is called before the first frame update
    void Start()
    {
        Chest = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("hitbox"))
        {
            Chest.SetTrigger("chestOpen");
            boxCollider2D.enabled = false;
            pickUpOrb.SetActive(true);
        }
    }
    
    public void AnimationFinished()
    {
        Chest.SetTrigger("ReturnToIdleTrigger");
    }
}
