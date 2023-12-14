using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement1 : MonoBehaviour
{
    PlayerControls controls;

    private float horizontal;
    public float speed = 8f;
    private float jumpPower = 18f;
    public bool isFacingRight = true;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Use input system
    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.ChapterOne.Move.performed += ctx =>
        {
            horizontal = ctx.ReadValue<float>();
        };

        controls.ChapterOne.Jump.performed += ctx =>
        {
            if (IsGrounded())
            {
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Chapter1"))
                {
                    if (!DialogueManager.GetInstance().dialogueIsPlaying)
                    {
                        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
                    }
                } else
                { 
                    rb.velocity = new Vector2(rb.velocity.x, jumpPower);
                }
                
            }
                
        };
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Chapter1"))
        {
            //Freeze movement if in dialogue
            if (DialogueManager.GetInstance().dialogueIsPlaying)
            {
                return;
            }
        }

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y); 

        Flip();
    }


    // If player is touching the ground
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }


    // Flip sprite when changing directions
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
