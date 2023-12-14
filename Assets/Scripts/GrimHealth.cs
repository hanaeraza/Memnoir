using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrimHealth : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        Debug.Log("Max health set to: " + health);
    }

    public void SetHealth(int health)
    {
        slider.value -= health;
        //Debug.Log("Taking: " + health + " damage. Setting health to: " + slider.value);
    }

}
