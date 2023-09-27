using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using System;

namespace InterDineMension
{
    public class dialogueManager : MonoBehaviour
    {
        private static dialogueManager instance;

        [SerializeField] private GameObject dialoguePanel;
        [SerializeField] private TextMeshProUGUI dialogueText;

        [SerializeField] private GameObject[] choices;

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
        }

        public static dialogueManager GetInstance()
        {
            return instance;
        }

        private void Start()
        {
            dialoguePlaying = false;
            dialoguePanel.SetActive(false);

            choicesText=new TextMeshProUGUI[choices.Length];
            int index = 0;
            foreach (GameObject choice in choices)
            {
                choicesText[index]=choice.GetComponentInChildren<TextMeshProUGUI>();
                index++;
            }


        }

        private void Update()
        {
            if (!dialoguePlaying) 
            {
                return;
            }
            if(Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Z)) 
            {
                ContinueStory();
            }
        }

        public void EnterDialogueMode(TextAsset inkJSON)
        {
            currentStory=new Story(inkJSON.text);
            dialoguePlaying=true;
            dialoguePanel.SetActive(true);

            ContinueStory();
        }

        private void ContinueStory()
        {
            if (currentStory.canContinue)
            {
                dialogueText.text = currentStory.Continue();
                DisplayChoices();
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
    }
}
