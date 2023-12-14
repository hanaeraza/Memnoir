using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Smite : MonoBehaviour
{
    public int smiteDamage = 50;
    public Rigidbody2D rb;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collision!"); 
        PlayerActions player = collision.GetComponent<PlayerActions>();
        GrimReaper grim = collision.GetComponent<GrimReaper>();
        if (player != null)
        {
            player.TakeDamage(smiteDamage);
        }
        if (grim != null)
        {
            grim.TakeDamage(smiteDamage);
        }
        Destroy(gameObject);
    }
}

