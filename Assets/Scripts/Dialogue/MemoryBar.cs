using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class MemoryBar : MonoBehaviour
{
    public int maximum = 100;
    public int minimum = 0;
    public int current = 50;

    [SerializeField] public TMP_Text MemoryProgress;

    void GetCurrentProgress()
    {
        MemoryProgress = GetComponent<TMP_Text>();
        if (MemoryProgress == null)
        {
            Debug.Log("Memory progress is null");
        }
        Debug.Log(MemoryProgress.text); 
        current = int.Parse(MemoryProgress.text.TrimEnd('%'));
        
    }

    public void SetProgress(int progressVal)
    {
        GetCurrentProgress();
        
        // Clamp between values 0 and 100
        if (current < maximum && current > 0)
        {
            current += progressVal;
            if (current > maximum)
            {
                current = maximum;
            }
            if (current < minimum)
            {
                current = minimum;
            }
        }

        Debug.Log("Current progress set to: " + current); 
        MemoryProgress.text = current + "%";
    }
}
