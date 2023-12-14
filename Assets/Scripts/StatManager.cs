using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    public static StatManager instance;

    public int playerMaxHealth = 100;
    public float playerDamageModifier = 1;
    public float playerMoveSpeedMod = 1;
    public int grimMaxHealth = 300;
    public int memoryPercent = 50;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject); 
    }
    public void UpdateHealth()
    {
        GameObject healthBar = GameObject.Find("HealthBar2"); 
        PlayerHealth health = healthBar.GetComponent<PlayerHealth>();
        health.SetMaxHealth(playerMaxHealth);
    }

    public void UpdateGrimHealth()
    {
        GameObject healthBar = GameObject.Find("HealthBarGrim");
        PlayerHealth health = healthBar.GetComponent<PlayerHealth>();
        health.SetMaxHealth(grimMaxHealth);
        //Debug.Log("Set grim health to: " + health.slider.value); 
    }

    public void UpdateSpeed()
    {
        GameObject player = GameObject.Find("Player");
        PlayerMovement1 playerSpeed = player.GetComponent<PlayerMovement1>();
        playerSpeed.speed *= playerMoveSpeedMod;
        Debug.Log("Speed updated to: " + playerSpeed.speed); 
    }

    public void UpdateDamage()
    {
        GameObject player = GameObject.Find("Player");
        PlayerActions playerDamage = player.GetComponent<PlayerActions>();
        playerDamage.damage = 10 * playerDamageModifier;
        Debug.Log("Damage updated to: " + playerDamage.damage);
    }
}
