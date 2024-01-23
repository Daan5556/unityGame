using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isGrounded;
    public SpriteRenderer spriteRenderer;
    private CircleCollider2D hitboxCollider;
    public Transform mainCharacterHitbox;

    // Start is called before the first frame update
    void Start()    
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Flip based on movement
        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false;
            mainCharacterHitbox.localPosition = new Vector3(
            Mathf.Abs(mainCharacterHitbox.localPosition.x) * 1,
            mainCharacterHitbox.localPosition.y,
            mainCharacterHitbox.localPosition.z
            );
        }

        if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
            mainCharacterHitbox.localPosition = new Vector3(
            Mathf.Abs(mainCharacterHitbox.localPosition.x) * -1,
            mainCharacterHitbox.localPosition.y,
            mainCharacterHitbox.localPosition.z
        );
        }
        // Jump
        if (Input.GetKey(KeyCode.Space) && isGrounded) 
        {
            jump();
        }
    }
    
    void jump()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        isGrounded = false;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground") ^ other.gameObject.CompareTag("Player"))
        {
            isGrounded = true;
        }
    }
}
