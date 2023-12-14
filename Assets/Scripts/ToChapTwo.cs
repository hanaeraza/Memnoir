using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class ToChapTwo : MonoBehaviour
{
    public static ToChapTwo instance;

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
    public void LoadChapTwo()
    {
        //StatManager.instance.memoryPercent = memory.GetCurrentProgress(); 
        SceneManager.LoadScene(2);
        StartCoroutine(WaitForSceneLoad());

        //health2.SetMaxHealth(StatManager.instance.playerMaxHealth);
        Debug.Log("player max health: " + StatManager.instance.playerMaxHealth +
            "\n player speed mod: " + StatManager.instance.playerMoveSpeedMod +
            "\n player damage mod: " + StatManager.instance.playerDamageModifier +
            "\n grim health: " + StatManager.instance.grimMaxHealth +
            "\n memory: " + StatManager.instance.memoryPercent);

        //Debug.Log("Slider max value: " + slider2.maxValue);
    }

    private IEnumerator WaitForSceneLoad()
    {
        while (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Chapter2"))
        {
            Debug.Log("Scene is still not chapter 2"); 
            yield return null;
        }
        Debug.Log("Scene has entered chapter 2"); 
        StatManager.instance.UpdateHealth();
        StatManager.instance.UpdateGrimHealth();
        StatManager.instance.UpdateSpeed();
        StatManager.instance.UpdateDamage(); 

    }
}
