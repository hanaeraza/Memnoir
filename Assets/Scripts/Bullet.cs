using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 15f;
    public float bulletDamage = 10;
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        rb.velocity = transform.right * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GrimReaper grimReaper = collision.GetComponent<GrimReaper>();
        if (grimReaper != null)
        {
            grimReaper.TakeDamage(bulletDamage); 
        }
        Destroy(gameObject); 
    }

    public void UpdateDamageMod(float damageMod)
    {
        
        bulletDamage = damageMod;
        //Debug.Log("Damage in UpdateDamageMod updated to: " + bulletDamage);
    }
}
