using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;

public class DialogueManager : MonoBehaviour
{
    PlayerControls controls;

    [Header("Dialogue UI")]

    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private GameObject grimReaper;
    public GameObject grimReaper2Prefab;
    public Transform grimReaperTransform; 

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;

    private TextMeshProUGUI[] choicesText;


    private Story currentStory;

    public bool dialogueIsPlaying { get; private set; }

    private static DialogueManager instance;

    [SerializeField] private ToChapTwo chapTwo;

    [Header("Variables")]
    [SerializeField] private MemoryBar memory;
    [SerializeField] private PlayerHealth health;
    [SerializeField] private Fader victim;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
        }
        instance = this;

        //chapTwo = new ToChapTwo();

        controls = new PlayerControls();
        controls.Enable();

        // Continue story on click/submit, when there are no choices
        controls.ChapterOne.Submit.performed += ctx =>
        {
            //Debug.Log("Submit pressed"); 
            if (currentStory.currentChoices.Count == 0)
            {
                //Debug.Log("No choices here, let's continue"); 
                ContinueStory(); 
            }

        };
    }
    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        // choices
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++; 
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        //dialogueVariables.StartListening(currentStory); // listen for variable changes
        StartListening(currentStory); 

        Debug.Log("Entering dialogue"); 
        ContinueStory(); 

    }

    private IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.2f); //To prevent jumping after ending dialogue

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";

        // Second part of grim reaper dialogue
        if (currentStory.globalTags.Contains("GrimReaper1"))
        {
            Vector3 grimPosition = grimReaper.transform.position;
            yield return new WaitForSeconds(0.1f); 
            Destroy(grimReaper);
            Instantiate(grimReaper2Prefab, grimPosition, Quaternion.identity);
            
        }
        
    }

    private void ContinueStory()
    {
         
        if (currentStory.canContinue)
        {
            //Debug.Log("Story continuing");
            dialogueText.text = currentStory.Continue();
            DisplayChoices(); 
        }
        else 
        {
            //Debug.Log("Exit dialogue"); 
            StartCoroutine(ExitDialogueMode());
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("Too many choices. Number of choices given: " + currentChoices.Count); 
        }

        // initialize amount of choices for this line of dialogue
        int index = 0; 
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false); 
        }

    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        //Debug.Log("Picked choice:" + choicesText[choiceIndex].text);
        ContinueStory(); 
    }

    public void StartListening(Story story)
    {
        story.ObserveVariable("picture_choice", (string varName, object newValue) => PictureChoice(newValue));
        story.ObserveVariable("mug_choice", (string varName, object newValue) => MugChoice(newValue));
        story.ObserveVariable("got_key", (string varName, object newValue) => KeyChoice(newValue));
        story.ObserveVariable("victim_choice", (string varName, object newValue) => VictimChoice(newValue));
        story.ObserveVariable("final_choice", (string varName, object newValue) => FinalChoice(newValue));
        story.ObserveVariable("ready_to_fight", (string varName, object newValue) => FightChoice(newValue));
    }

    private void PictureChoice(object newValue)
    {
        //Debug.Log("ObserveVariable observed new choice made: " + newValue);

        switch (newValue)
        {
            case "":
                Debug.LogWarning("Blank choice");
                break;
            case "Reminisce":
                health.SetMaxHealth(150);
                memory.SetProgress(10);
                StatManager.instance.playerMaxHealth = 150; 
                Debug.Log("Reminisce: Max health increased!");
                break;
            case "Shatter":
                health.SetMaxHealth(50); 
                memory.SetProgress(-10);
                StatManager.instance.playerMaxHealth = 50;
                Debug.Log("Shatter: Max health decreased!");
                break;
        }
    }

    private void MugChoice(object newValue)
    {
        //Debug.Log("ObserveVariable observed new choice made: " + newValue);
        switch (newValue)
        {
            case "":
                Debug.LogWarning("Blank choice");
                break;
            case "Replace":
                memory.SetProgress(10);
                StatManager.instance.playerDamageModifier = 1.5f;
                Debug.Log("Replace: Damage Increased!");
                break;
            case "Kick":
                memory.SetProgress(-10);
                StatManager.instance.playerDamageModifier = 0.5f;
                Debug.Log("Kick: Damage decreased!");
                break;
        }
    }
    private void VictimChoice(object newValue)
    {
        //Debug.Log("ObserveVariable observed new choice made: " + newValue);
        switch (newValue)
        {
            case "":
                Debug.LogWarning("Blank choice");
                break;
            case "Apologize":
                memory.SetProgress(10);
                StatManager.instance.playerMoveSpeedMod = 1.5f;
                victim.FadeOut(); 
                Debug.Log("Apologize: Increased movement speed!");
                break;
            case "Unapologetic":
                memory.SetProgress(-10);
                StatManager.instance.playerMoveSpeedMod = 0.5f;
                Debug.Log("Unapologetic: Reduced movement speed!");
                break;
        }
    }
    private void KeyChoice(object newValue)
    {
        //Debug.Log("ObserveVariable observed new choice made: " + newValue);
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
        //Debug.Log("ObserveVariable observed new choice made: " + newValue);
        switch (newValue)
        {
            case "":
                Debug.LogWarning("Blank choice");
                break;
            case "Right":
                memory.SetProgress(20);
                StatManager.instance.grimMaxHealth = 150;
                Debug.Log("Right: Grim Reaper Nerfed!");
                break;
            case "Wrong":
                memory.SetProgress(-20);
                StatManager.instance.grimMaxHealth = 450;
                Debug.Log("Wrong: Grim Reaper Buffed!");
                break;
        }
    }

    private void FightChoice(object newValue)
    {
        //Debug.Log("ObserveVariable observed new choice made: " + newValue);
        switch (newValue)
        {
            case "":
                Debug.LogWarning("Blank choice");
                break;
            case true:
                Debug.Log("Ready to fight!");
                chapTwo.LoadChapTwo(); 
                break;
            case false:
                Debug.Log("Not ready to fight");
                break;
        }
    }
}
