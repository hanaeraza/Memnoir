using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    PlayerControls controls;
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public GameObject bulletPrefab;
    public float damage = 1f; 

    float timeUntilFire;
    PlayerMovement1 pm;
    public SpriteRenderer spriteRenderer;
    [SerializeField] private Fader fader;
    public GameOverScreen GameOverScreen; 

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();
        controls.ChapterTwo.Shoot.performed += ctx => Shoot();
    }

    private void Start()
    {
        pm = gameObject.GetComponent<PlayerMovement1>();
        //bulletPrefab.GetComponent<Bullet>().UpdateDamageMod(damage);
    }

    void Shoot()
    {
        if(timeUntilFire < Time.time)
        {
            float angle = pm.isFacingRight ? 0f : 180f;
            Instantiate(bulletPrefab, firingPoint.position, Quaternion.Euler(new Vector3(0, 0, angle)));
            bulletPrefab.GetComponent<Bullet>().UpdateDamageMod(damage);
            timeUntilFire = Time.time + fireRate;
        }
    }

    public void TakeDamage(int damage)
    {
        GameObject healthBar = GameObject.Find("HealthBar2");
        PlayerHealth health = healthBar.GetComponent<PlayerHealth>();
        if (healthBar != null)
        {
            Debug.Log("Taking damage: " + damage); 
            health.SetHealth(damage);
            StartCoroutine(HitFlash()); 
        } else
        {
            Debug.Log("Healthbar is null"); 
        }

        if (health.slider.value <= 0)
        {
            GameOver();
        }
    }


    IEnumerator HitFlash()
    {
            spriteRenderer.color = new Color(1, 0.5f, 0.5f, 1);
            yield return new WaitForSeconds(0.2f);
            spriteRenderer.color = Color.white;
            yield return null;
        
    }


    public void GameOver()
    {
        Destroy(gameObject);
        GameOverScreen.Setup(); 
        Debug.Log("Game Over!"); 
    }
}
