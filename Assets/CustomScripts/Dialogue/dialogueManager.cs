using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using System;

namespace InterDineMension.Manager
{
    public class dialogueManager : MonoBehaviour
    {
        private static dialogueManager instance;

        [SerializeField] private GameObject dialoguePanel;
        [SerializeField] private TextMeshProUGUI dialogueText;

        [SerializeField] private GameObject[] choices;

        [SerializeField] public TextAsset inkJSON;

        private TextMeshProUGUI[] choicesText;

        private Story currentStory;

        public bool dialoguePlaying { get; private set; }

        private void Awake()
        {
            if (instance != null)
            {
                Debug.LogWarning("Found more then one DialogueManager instance");
            }
            instance = this;
            
            dialoguePlaying = false;
            dialoguePanel.SetActive(false);
            choicesText = new TextMeshProUGUI[choices.Length];
            int index = 0;
            foreach (GameObject choice in choices)
            {
                choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
                index++;
            }
        }

        public static dialogueManager GetInstance()
        {
            return instance;
        }

        private void Start()
        {
         
        }

        private void Update()
        {
            if (!dialoguePlaying) 
            {
                return;
            }
            if(currentStory.currentChoices.Count==0&&(Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Z)))
            {
                ContinueStory();
            }
        }

        public void EnterDialogueMode(TextAsset inkJSON)
        {
            dialoguePanel.SetActive(true);
            currentStory =new Story(inkJSON.text);
            dialoguePlaying=true;

            ContinueStory();
        }

        private void ContinueStory()
        {
            if (currentStory.canContinue)
            {
                dialogueText.text = currentStory.Continue();
                DisplayChoices();
                Debug.Log(currentStory.currentChoices.Count);
            }

            else
            {
                ExitDialogueMode();
            }
        }

        private void ExitDialogueMode()
        {
            dialoguePlaying = false;
            dialoguePanel.SetActive(false);
            dialogueText.text = "";
        }

        private void DisplayChoices()
        {
            List<Choice> currentChoices = currentStory.currentChoices;
            if (currentChoices.Count > choices.Length)
            {
                //just to prevent error
                Debug.LogError("More choies were given than the UI can support. Number of choices given: " + currentChoices.Count);

            }

            int index = 0;
            foreach (Choice choice in currentChoices)
            {
                choices[index].gameObject.SetActive(true);
                choicesText[index].text = choice.text;
                index++;
            }

            for(int i = index; i<choices.Length; i++)
            {
                choices[i].gameObject.SetActive(false);
            }
        }

        public void MakeChoice(int choiceIndex)
        {
            currentStory.ChooseChoiceIndex(choiceIndex);
        }
    }
}
