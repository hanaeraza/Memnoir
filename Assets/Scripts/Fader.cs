using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public float fadeSpeed = 0.1f; 
    public void FadeOut()
    {
        Debug.Log("In fadeOut function"); 
        StartCoroutine(FadeOutTimed());
        
    }

    IEnumerator FadeOutTimed()
    {
        Debug.Log("In fadeoutTIMED function"); 

        for (float f = 1f; f > -0.1f; f -= 0.05f)
        {
            Color objectColor = this.GetComponent<SpriteRenderer>().color;
            objectColor.a = f;
            this.GetComponent<SpriteRenderer>().color = objectColor;
            yield return new WaitForSeconds(0.1f); 
        }
        Destroy(gameObject);
    }
}
