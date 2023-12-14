using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimReaper : MonoBehaviour
{
   public float grimHealth = 300;
    private Rigidbody2D rb;
    public Transform target;
    public bool isFacingRight = true;
    float timeUntilSmite;
    public float smiteRate = 5f;
    float timeUntilDeathTouch;
    public float touchRate = 0.5f;
    public GameObject smitePrefab;
    Vector3 smitePosition = new Vector3(0, 5, 0);
    public float moveSpeed = 2f;
    public Vector3 moveDirection;
    public SpriteRenderer spriteRenderer;
    public GameOverScreen GameOverScreen;
     

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Find player and face them
        if (target)
        {
            Flip();

            smitePosition.x = target.position.x;
            moveDirection = (target.position - transform.position).normalized;

            Smite();
        }
    }

    void FixedUpdate()
    {
        if (target)
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y); 
    }

    void Smite()
    {
        if (timeUntilSmite < Time.time && target)
        {
            Instantiate(smitePrefab, smitePosition, Quaternion.identity);
            timeUntilSmite = Time.time + smiteRate;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        PlayerActions player = collision.gameObject.GetComponent<PlayerActions>();
        if (player != null)
        {
            if (timeUntilDeathTouch < Time.time)
            {
                player.TakeDamage(5);
                timeUntilDeathTouch = Time.time + touchRate;
            }
            
        }
    }


    public void TakeDamage(float damage)
    {
        //grimHealth -= damage;
        StartCoroutine(HitFlash());

        GameObject healthBar = GameObject.Find("HealthBarGrim");
        PlayerHealth health = healthBar.GetComponent<PlayerHealth>();
        health.SetHealth(damage);
        if (health.slider.value <= 0)
        {
            Die(); 
        }
    }


    IEnumerator HitFlash()
    {
        spriteRenderer.color = new Color(0.7f, 0.5f, 0.5f, 1);
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.color = Color.white;
        yield return null;
    }


    void Die()
    {
        Destroy(gameObject);
        GameOverScreen.Setup(); 
        Debug.Log("You win!"); 
    }


    // Flip sprite towards player
    private void Flip()
    {

        if (isFacingRight && transform.position.x < target.position.x || !isFacingRight && transform.position.x > target.position.x)
        {
            //Debug.Log("Flipped: " + isFacingRight);
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
