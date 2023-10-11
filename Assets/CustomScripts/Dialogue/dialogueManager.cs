using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using System;

namespace InterDineMension.Manager
{
    using InterDineMension.Character;
    using MicroGame;
    using MicroGame.BA;
    public class dialogueManager : MonoBehaviour
    {
        //tutorial made it a private serializeField, but I want to be able to adjust this with settings
        public float typingSpeed = 0.04f;
        private Coroutine displayLineCorutine;
        private DialogueVariables dV;
        private bool canContinueToNextLine = false;
        public CheffSwatts cS = new CheffSwatts();
        public Graciana grac=new Graciana();

        public enum speaker { Graciana, Swatts};
        public speaker charSpeak;

        private static dialogueManager instance;

        [SerializeField] private GameObject dialoguePanel;
        [SerializeField] private TextMeshProUGUI dialogueText;
        [SerializeField] private TextMeshProUGUI displayNameText;
        [SerializeField] private GameObject continueIcon;

        [SerializeField] private GameObject[] choices;

        [SerializeField] public TextAsset inkJSON;
        [SerializeField] public TextAsset inkJSON2;
        [SerializeField] private TextAsset loadGlobalsJSON;

        private TextMeshProUGUI[] choicesText;

        private Story currentStory;

        public Microgamecontroller mGC;
        public BAManeger bAM;

        public bool dialoguePlaying { get; private set; }
        /// <summary>
        /// this is for the BAMicro game
        /// </summary>
        private const string SPEAKER_TAG = "speaker";
        private const string BBUN_TAG = "BBun";
        private const string PICKLES_TAG = "Pickles";
        private const string LETTUCE_TAG = "lettuce";
        private const string PATTY_TAG = "patty";
        private const string CONDIMENTS_TAG = "Condiments";
        private const string VEGGIE_TAG = "veggie";
        private const string TBUN_TAG = "TBun";
        private const string MOOD = "mood";

        public InkExternalFunctions iEF=new InkExternalFunctions();

        private void Awake()
        {
            dV = new DialogueVariables(loadGlobalsJSON); 
             
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

        public void StartFirstConvo()
        {
            EnterDialogueMode(inkJSON);
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
            if(canContinueToNextLine&& currentStory.currentChoices.Count==0&&(Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Z)||Input.GetKey(KeyCode.LeftControl)))
            {
                ContinueStory();
            }
        }

        public void EnterDialogueMode(TextAsset inkJSON)
        {
            dialoguePanel.SetActive(true);
            currentStory =new Story(inkJSON.text);
            dialoguePlaying=true;

            dV.StartListening(currentStory);

            /*currentStory.BindExternalFunction("StartBAMicro", () =>
            {
                 Debug.Log("called StartBAMicro");
             });*/

            iEF.Bind(currentStory,bAM,mGC);
            ContinueStory();
        }


        /// <summary>
        /// this is a a function that will be called by the debug button to do any number of things.
        /// </summary>
        public void debugCommand()
        {
            
            EnterDialogueMode(inkJSON);
        }

        private void ContinueStory()
        {
            if (currentStory.canContinue)
            {
                //set text for current dialogue line
                if (displayLineCorutine != null)
                {
                    StopCoroutine(displayLineCorutine);
                }

                displayLineCorutine=StartCoroutine(DisplayLine(currentStory.Continue()));
                /*dialogueText.text = currentStory.Continue(); outdated*/ 
                HandleTags(currentStory.currentTags);
                //Debug.Log(currentStory.currentChoices.Count);
            }

            else
            {
                ExitDialogueMode();
            }
        }

        /// <summary>
        /// used for typing effect
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private IEnumerator DisplayLine(string line)
        {
            //empty dialogue text
            dialogueText.text = "";
            Hidechoices();
            continueIcon.SetActive(false);

            canContinueToNextLine = false;

            bool isAddingRichTextTag = false;

            //display each letter one at a time. 
            foreach(char letter in line.ToCharArray())
            {
                //if the submit button is pressed, finish up displaying the line right away
                if (Input.GetKey(KeyCode.LeftControl))
                {
                    dialogueText.text = line;
                    break;
                }

                //check for rich text tag, if found add all without waiting
                if(letter=='<'|| isAddingRichTextTag)
                {
                    isAddingRichTextTag=true;
                    dialogueText.text += letter;
                    if (letter == '>')
                    {
                        isAddingRichTextTag=false;
                    }
                }
                //otherwise can continue at normal speed
                else
                {
                    dialogueText.text += letter;
                    yield return new WaitForSeconds(typingSpeed);
                }
                
            }
            DisplayChoices();
            continueIcon.SetActive(true);
            canContinueToNextLine = true;
        }

        private void Hidechoices()
        {
            foreach(GameObject choiceButton in choices)
            {
                choiceButton.SetActive(false);
            }
        }

        private void HandleTags(List<string> currentTags)
        {
            foreach(string tag in currentTags)
            {
                string[] splitTag = tag.Split(':');
                if (splitTag.Length != 2)
                {
                    Debug.LogError("Tag could not be appropriatly parsed: " + tag);
                }
                string tagKey = splitTag[0].Trim();
                string tagValue = splitTag[1].Trim();

                switch (tagKey)
                {
                    case MOOD:
                        {
                            switch (charSpeak)
                            {
                                case speaker.Graciana:
                                    {
                                        grac.sR.sprite = grac.spriteDictionary[tagValue];
                                        /*switch(tagValue) 
                                        {
                                            case "annoyed":
                                                {
                                                    break;
                                                }
                                            case "happy":
                                                {
                                                    break;
                                                }
                                            case "money":
                                                {
                                                    break;
                                                }
                                            case "neutral":
                                                {
                                                    break;
                                                }
                                            case "sad":
                                                {
                                                    break;
                                                }
                                            case "think":
                                                {
                                                    break;
                                                }
                                            default:Debug.LogWarning("tag value not recognized for mood");break;
                                        }*/ //hopefully I won't need to use this
                                    }
                                    break;
                                case speaker.Swatts:
                                    {
                                        cS.sR.sprite = cS.spriteDictionary[tagValue];
                                        /*switch (tagValue)
                                        {


                                            case "annoyed":
                                                {
                                                    break;
                                                }
                                            case "happy":
                                                {
                                                    break;
                                                }
                                            case "neutral":
                                                {
                                                    break;
                                                }
                                            case "pray":
                                                {
                                                    break;
                                                }
                                            case "sad":
                                                {
                                                    break;
                                                }
                                            default:
                                                Debug.LogWarning("tag value not recognized for mood"); break;
                                        }*/
                                        break;
                                    }
                                default:break;
                                }
                            break;
                        }
                    case SPEAKER_TAG:
                        displayNameText.text = tagValue;
                        break;
                    case BBUN_TAG:
                        switch (tagValue)
                        {
                            case "Plain":
                                mGC.orderedIngredients[0] = BurgerIngredients.ingredientType.classicBottomBun;
                                break;
                            case "Lettucebun":
                                mGC.orderedIngredients[0] = BurgerIngredients.ingredientType.lettuceWrapBottom;
                                break;
                            case "None":
                                mGC.orderedIngredients[0] = BurgerIngredients.ingredientType.noBottomBun;
                                break;
                            default:
                                Debug.LogWarning($"BBun value {tagValue} has not been recongnized");
                                break;
                        }
                        break;
                    case PICKLES_TAG:
                        switch (tagValue)
                        {
                            case "Chips":
                                mGC.orderedIngredients[1] = BurgerIngredients.ingredientType.pickles;
                                break;
                            case "Relish":
                                mGC.orderedIngredients[1] = BurgerIngredients.ingredientType.relish;
                                break;
                            case "None":
                                mGC.orderedIngredients[1] = BurgerIngredients.ingredientType.noPickles;
                                break;
                            default:
                                Debug.LogWarning($"Pickles value {tagValue} has not been recongnized");
                                break;
                        }
                        break;
                    case LETTUCE_TAG:
                        switch (tagValue)
                        {
                            case "Leaf":
                                mGC.orderedIngredients[2] = BurgerIngredients.ingredientType.wholeLeafLettuce;
                                break;
                            case "Chopped":
                                mGC.orderedIngredients[2] = BurgerIngredients.ingredientType.choppedLettuce;
                                break;
                            case "None":
                                mGC.orderedIngredients[2] = BurgerIngredients.ingredientType.noLettuce;
                                break;
                            default:
                                Debug.LogWarning($"Lettuce value {tagValue} has not been recongnized");
                                break;
                        }
                        break;
                    case PATTY_TAG:
                        switch (tagValue)
                        {
                            case "Beef":
                                mGC.orderedIngredients[3] = BurgerIngredients.ingredientType.beefPatty;
                                break;
                            case "Vegan":
                                mGC.orderedIngredients[3] = BurgerIngredients.ingredientType.veganPatty;
                                break;
                            default:
                                Debug.LogWarning($"Patty value {tagValue} has not been recongnized");
                                break;
                        };
                        break;
                    case CONDIMENTS_TAG:
                        switch (tagValue)
                        {
                            case "Ketchup":
                                mGC.orderedIngredients[4] = BurgerIngredients.ingredientType.ketchup;
                                break;
                            case "Mustard":
                                mGC.orderedIngredients[4] = BurgerIngredients.ingredientType.mustard;
                                break;
                            case "Both":
                                mGC.orderedIngredients[4] = BurgerIngredients.ingredientType.both;
                                break;
                            default:
                                Debug.LogWarning($"Condiments value {tagValue} has not been recongnized");
                                break;
                        }
                        break;
                    case VEGGIE_TAG:
                        switch (tagValue)
                        {
                            case "Tomatoe":
                                mGC.orderedIngredients[5] = BurgerIngredients.ingredientType.tomatoe;
                                break;
                            case "Onion":
                                mGC.orderedIngredients[5] = BurgerIngredients.ingredientType.choppedOnions;
                                break;
                            case "None":
                                mGC.orderedIngredients[5] = BurgerIngredients.ingredientType.none;
                                break;
                            default:
                                Debug.LogWarning($"Veggie value {tagValue} has not been recongnized");
                                break;
                        }
                        break;
                    case TBUN_TAG:
                        switch (tagValue)
                        {
                            case "Plain":
                                mGC.orderedIngredients[6] = BurgerIngredients.ingredientType.classicTopBun;
                                break;
                            case "Lettucebun":
                                mGC.orderedIngredients[6] = BurgerIngredients.ingredientType.lettuceWrapTop;
                                break;
                            case "None":
                                mGC.orderedIngredients[6] = BurgerIngredients.ingredientType.noTopBun;
                                break;
                            default:
                                Debug.LogWarning($"TBun value {tagValue} has not been recongnized");
                                break;
                        }
                        break;
                    default:
                        Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                        break;
                }
            }
        }

        private void ExitDialogueMode()
        {
            dV.StopListening(currentStory);

            currentStory.UnbindExternalFunction("StartBAMicro");
            
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
            if (canContinueToNextLine)
            {
                currentStory.ChooseChoiceIndex(choiceIndex);
                ContinueStory();
            }
        }

        public Ink.Runtime.Object GetVariableState(string variableName)
        {
            Ink.Runtime.Object variableValue = null;
            dV.variables.TryGetValue(variableName, out variableValue);
            if(variableValue==null)
            {
                Debug.LogWarning("Ink Variable was found to be null: " + variableName);
            }
            return variableValue;
        }

        public void OnApplicationQuit()
        {
            if(dV != null)
            {
                dV.SaveVariables();
            }
            
        }
    }
}
