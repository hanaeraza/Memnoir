// Reference: https://www.youtube.com/watch?v=fA79neqH21s 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class DialogueVariables : MonoBehaviour
{
    public MemoryBar memory;
    public PlayerHealth healthBar;
    public ToChapTwo chapTwo; 
    public int maxHealth = 80;

    public void Awake()
    {
        //memory = new MemoryBar();

        healthBar = gameObject.GetComponent<PlayerHealth>();

        //healthBar = new PlayerHealth();
        Debug.Log("Healthbar set"); 
    }
    
    public void StartListening(Story story)
    {
        Debug.Log("I have started listening");

            //healthBar.SetMaxHealth(maxHealth + 5);

            Debug.Log("Health bar is null"); 


        //memory = new MemoryBar();

        story.ObserveVariable("picture_choice", (string varName, object newValue) => PictureChoice(newValue));
        story.ObserveVariable("mug_choice", (string varName, object newValue) => MugChoice(newValue));
        story.ObserveVariable("got_key", (string varName, object newValue) => KeyChoice(newValue));
        story.ObserveVariable("victim_choice", (string varName, object newValue) => VictimChoice(newValue));
        story.ObserveVariable("final_choice", (string varName, object newValue) => FinalChoice(newValue));

        /*
        object picture_choice;
        object mug_choice;
        object got_key;
        object victim_choice;
        object final_choice; 

        story.ObserveVariable("picture_choice", (string varName, object newValue) => picture_choice = newValue);
        story.ObserveVariable("mug_choice", (string varName, object newValue) => mug_choice = newValue);
        story.ObserveVariable("got_key", (string varName, object newValue) => got_key = newValue);
        story.ObserveVariable("victim_choice", (string varName, object newValue) => victim_choice = newValue);
        story.ObserveVariable("final_choice", (string varName, object newValue) => final_choice = newValue);*/
    }

    private void PictureChoice(object newValue)
    {
        Debug.Log("ObserveVariable observed new choice made: " + newValue);
        if (memory != null)
        {
            memory.SetProgress(5);
        }
        else
        {
            Debug.Log("Memory is null"); 
        }

        //chapTwo.LoadChapTwo(); 
        Debug.Log("I am after setProgress"); 
        switch (newValue)
        {
            case "":
                Debug.LogWarning("Blank choice");
                break;
            case "Reminisce":
                Debug.Log("Reminisce: Health increased!");
                break;
            case "Shatter":
                Debug.Log("Shatter: Health decreased!");
                break;
        }
    }
    private void MugChoice(object newValue)
    {
        Debug.Log("ObserveVariable observed new choice made: " + newValue);
        switch (newValue)
        {
            case "":
                Debug.LogWarning("Blank choice");
                break;
            case "Replace":
                Debug.Log("Replace: Damage Increased!");
                break;
            case "Kick":
                Debug.Log("Kick: Damage decreased!");
                break;
        }
    }
    private void VictimChoice(object newValue)
    {
        Debug.Log("ObserveVariable observed new choice made: " + newValue);
        switch (newValue)
        {
            case "":
                Debug.LogWarning("Blank choice");
                break;
            case "Apologize":
                Debug.Log("Apologize: Gained Phantom Blast Attack!");
                break;
            case "Unapologetic":
                Debug.Log("Unapologetic: Reduced movement speed!");
                break;
        }
    }
    private void KeyChoice(object newValue)
    {
        Debug.Log("ObserveVariable observed new choice made: " + newValue);
        switch (newValue)
        {
            case false:
                Debug.LogWarning("Blank choice");
                break;
            case true:
                Debug.Log("Acquired Basement Key!");
                break;
        }
    }

    private void FinalChoice(object newValue)
    {
        Debug.Log("ObserveVariable observed new choice made: " + newValue);
        switch (newValue)
        {
            case "":
                Debug.LogWarning("Blank choice");
                break;
            case "Right":
                Debug.Log("Right: Grim Reaper Nerfed!");
                break;
            case "Wrong":
                Debug.Log("Wrong: Grim Reaper Buffed!");
                break;
        }
    }

}
