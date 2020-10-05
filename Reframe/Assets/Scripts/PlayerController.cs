using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRend;
    private Vector2 movement;

    private bool facingLeft = false;

    private void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
        spriteRend = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if(facingLeft && movement.x > 0)
        {
            spriteRend.flipX = !spriteRend.flipX;
            facingLeft = false;
        }
        if (!facingLeft && movement.x < 0)
        {
            spriteRend.flipX = !spriteRend.flipX;
            facingLeft = true;
        }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "GoodEnd")
        {
            SceneManager.LoadScene("Good_Ending");
        }
    }
}
