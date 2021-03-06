﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public AudioClip walking;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRend;
    private Animator anim;
    private Vector2 movement;
    AudioSource audioSrc;

    private bool facingLeft = false;

    private void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
        spriteRend = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if(movement != Vector2.zero)
        {
            anim.SetBool("Walking", true);
            audioSrc.UnPause ();
            
        }
        else
        {
            anim.SetBool("Walking", false);
            audioSrc.Pause ();
        }
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
        if (other.tag == "BadEnd")
        {
            SceneManager.LoadScene("Bad_Ending");
        }
    }
}
