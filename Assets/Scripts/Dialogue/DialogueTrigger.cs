//Reference: https://www.youtube.com/watch?v=vY0Sk93YUhA&t=592s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    PlayerControls controls;

    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON; 

    private bool playerInRange;
    private bool hasPlayed = false;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);

        controls = new PlayerControls();
        controls.Enable(); 
        controls.ChapterOne.Interact.performed += ctx => EnterDialogue(); 
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && hasPlayed == false)
        {
            visualCue.SetActive(true);
        } else
        {
            visualCue.SetActive(false); 
        }
    }

    void EnterDialogue()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying && hasPlayed == false)
        {
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            Debug.Log("Name of gameobject:" + gameObject.transform.parent.gameObject.name); 
            if (!(gameObject.transform.parent.gameObject.name == "GrimReaperPrefab2(Clone)"))
                hasPlayed = true;
        } 
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }



}
