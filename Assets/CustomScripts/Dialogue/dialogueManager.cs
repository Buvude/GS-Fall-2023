using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using System;
using UnityEngine.UI;

namespace InterDineMension.Manager
{
    using InterDineMension.Character;
    using JetBrains.Annotations;
    using MicroGame;
    using MicroGame.BA;
    using System.Reflection.Emit;
    using Unity.VisualScripting;
    //using UnityEngine.UIElements;

    public class dialogueManager : MonoBehaviour
    {
     
        //public GameObject charImageCS, charImageOR;
        //private bool deactivatedcorutines = false;
        public VariableHolder vH;
        public GameObject convoModeImages, charBtn;
        public dialogueSpriteManager manager;
        public GameObject[] dialogueObject;
        //tutorial made it a private serializeField, but I want to be able to adjust this with settings
        public float typingSpeed = 0.04f;
        private Coroutine displayLineCorutine;
        private DialogueVariables dV;
        private bool canContinueToNextLine = false;
        public CheffSwatts cS /*= new CheffSwatts()*/;
        public Graciana grac/*=new Graciana()*/;
        public O_Ryan oR;
        public CeeCee cC;
        public Gnomies G;

        public enum speaker { Graciana, Swatts,O_Ryan, CeeCee, Gnomies, Fred, None};
        public enum speakingTo {  O_Ryan, Swatts, CeeCee, Gnomies, Fred};
        public speaker charSpeak;
        public speakingTo charSpeakTo;

        private static dialogueManager instance;

        public GameObject dialoguePanel;


        [SerializeField] private Image dPTest;

        [SerializeField] private TextMeshProUGUI dialogueText;
        [SerializeField] private TextMeshProUGUI displayNameText;
        [SerializeField] private GameObject continueIcon;

        [SerializeField] private GameObject[] choices;

        [SerializeField] public TextAsset dayOneIntro;
        [SerializeField] public TextAsset O_RyanIntro;
        [SerializeField] private TextAsset loadGlobalsJSON;

        private TextMeshProUGUI[] choicesText;

        private Story currentStory;

        private bool exitedDialogueMode = false;

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
        //private const string VAR_CHANGE = "varChange"; not sure what this was supposed to me lmao

        public InkExternalFunctions iEF;
        public GameObject BBun2, Pickles2, Greens2, Patty2, Condiment2, Veggie2, TBun2;
        public GameObject BBun3, Pickles3, Greens3, Patty3, Condiment3, Veggie3, TBun3;
        private void Awake()
        {
           /* cS.sR.color = Color.HSVToRGB(0, 0, 40);*/
            grac.sR.color = Color.HSVToRGB(0, 0, 40);
            iEF = new InkExternalFunctions(BBun2, Pickles2, Greens2, Patty2, Condiment2, Veggie2, TBun2, BBun3, Pickles3, Greens3, Patty3, Condiment3, Veggie3, TBun3);
            dPTest = this.gameObject.GetComponent<Image>();
            dV = new DialogueVariables(loadGlobalsJSON); 
             
            if (instance != null)
            {
                Debug.LogWarning("Found more then one DialogueManager instance");
            }
            instance = this;
            
            dialoguePlaying = false;
            dPTest.enabled=true;
            choicesText = new TextMeshProUGUI[choices.Length];
            int index = 0;
            foreach (GameObject choice in choices)
            {
                choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
                index++;
            }
        }

        private void Start()
        {
            StartMorningConvo();//will need to be adjusted later
        }   

        public void StartMorningConvo()
        {
            //charSpeakTo = speakingTo.Swatts;
            EnterDialogueMode(dayOneIntro);
        }

        public static dialogueManager GetInstance()
        {
            return instance;
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
           /* if (!this.gameObject.activeInHierarchy&&!deactivatedcorutines)
            {
                deactivatedcorutines = true; 
                Debug.Log("No longer active in hierarchy");
                this.StopAllCoroutines();
            }
            else if(this.gameObject.activeInHierarchy && deactivatedcorutines)
            {
                deactivatedcorutines= false;
            }*/
        }
        public void setCharSpeakToCS()
        {
            charSpeakTo = speakingTo.Swatts;
        }

        public void EnterDialogueModeBTN()
        {
            switch (charSpeakTo)
            {
                case speakingTo.Swatts:
                    {
                        switch (iEF.csConvo)
                        {
                            case 0:
                                {
                                    EnterDialogueMode(cS.CS1);
                                    break;
                                }
                            case 1:
                                {
                                    EnterDialogueMode(cS.CS2);
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        public void EnterDialogueMode(TextAsset inkJSON)
        {
            exitedDialogueMode = false;
            charBtn.SetActive(false);
            convoModeImages.gameObject.SetActive(true);
            //dialogueObject.SetActive(true);
            foreach (GameObject item in dialogueObject)
            {
                item.SetActive(true);
            }

            //add method to determine which convo is going on, possibly triggered by the char btn
            dPTest.enabled = true;
            currentStory =new Story(inkJSON.text);
            dialoguePlaying=true;
            grac.gameObject.GetComponent<Image>().enabled = true;
            dV.StartListening(currentStory);

            switch (charSpeakTo)
            {
                case speakingTo.O_Ryan:
                    oR.gameObject.SetActive (true);
                    G.gameObject.SetActive(false);
                    cS.gameObject.SetActive(false);
                    cC.gameObject.SetActive(false);
                    break;
                case speakingTo.Swatts:
                    oR.gameObject.SetActive(false);
                    G.gameObject.SetActive(false);
                    cS.gameObject.SetActive(true);
                    cC.gameObject.SetActive(false);
                    break;
                case speakingTo.CeeCee:
                    oR.gameObject.SetActive(false);
                    G.gameObject.SetActive(false);
                    cS.gameObject.SetActive(false);
                    cC.gameObject.SetActive(true);
                    break;
                case speakingTo.Gnomies:
                    oR.gameObject.SetActive(false);
                    G.gameObject.SetActive(true);
                    cS.gameObject.SetActive(false);
                    cC.gameObject.SetActive(false);
                    break;
                case speakingTo.Fred:
                    break;
                default:
                    break;
            }
            /*currentStory.BindExternalFunction("StartBAMicro", () =>
            {
                 Debug.Log("called StartBAMicro");
             });*/

            iEF.Bind(currentStory,bAM,mGC,this);
            vH.currentStory = currentStory;
            ContinueStory();
        }

        
        /// <summary>
        /// this is a a function that will be called by the debug button to do any number of things.
        /// </summary>
        public void debugCommand()
        {
            
            EnterDialogueMode(dayOneIntro);
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
                displayLineCorutine = StartCoroutine(DisplayLine(currentStory.Continue()));
                /*dialogueText.text = currentStory.Continue(); outdated*/
                HandleTags(currentStory.currentTags);
                //Debug.Log(currentStory.currentChoices.Count);



            }

            else
            {
                ExitDialogueMode(false,0,0);
                dPTest.enabled = false;
            }
        }

        /// <summary>
        /// used for typing effect
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public IEnumerator DisplayLine(string line)
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
            if(!exitedDialogueMode)
            {
                continueIcon.SetActive(true);
            }
            
            canContinueToNextLine = true;
            yield return new WaitForEndOfFrame();
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
                                case speaker.O_Ryan:
                                    {
                                        Debug.Log("Got to o'ryan sprites");
                                        oR.sR.sprite= oR.spriteDictionary[tagValue];
                                        break;
                                    }
                                case speaker.CeeCee:
                                    {
                                        Debug.Log("Got to CeeCee sprites");
                                        cC.sR.sprite = cC.spriteDictionary[tagValue];
                                        break;
                                    }
                                case speaker.Gnomies:
                                    {
                                        Debug.Log("Got to gnomies sprites");
                                        G.sR.sprite = G.spriteDictionary[tagValue];
                                        break;
                                    }
                                default:Debug.Log("default"); break;
                                }
                            break;
                        }
                    case SPEAKER_TAG:
                        displayNameText.text = tagValue;
                        if(tagValue== "Chef Swatts")
                        {
                            cS.sR.color = Color.HSVToRGB(0, 0, 1, true);
                            grac.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                            charSpeak = speaker.Swatts;
                        }
                        else if(tagValue== "Graciana")
                        {
                            charSpeak = speaker.Graciana;
                            switch (charSpeakTo)
                            {
                                case speakingTo.O_Ryan:
                                    oR.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                    grac.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    break;
                                case speakingTo.Swatts:
                                    cS.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                    grac.sR.color = Color.HSVToRGB(0, 0, 1,false);
                                    break;
                                case speakingTo.CeeCee:
                                    cC.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                    grac.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    break;
                                case speakingTo.Gnomies:
                                    G.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                    grac.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    break;
                                default:
                                    grac.sR.color=Color.HSVToRGB(0,0, 1, true);
                                    break;
                            }
                        }
                        else if (tagValue == "O'Ryan")
                        {
                            oR.sR.color = Color.HSVToRGB(0, 0, 1);
                            grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                            charSpeak = speaker.O_Ryan;
                        }
                        else if (tagValue == "CeeCee") 
                        {
                            cC.sR.color = Color.HSVToRGB(0, 0, 1);
                            grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                            charSpeak = speaker.CeeCee;
                        }
                        else if (tagValue == "Gnomies")
                        {
                            G.sR.color = Color.HSVToRGB(0, 0, 1);
                            grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                            charSpeak = speaker.Gnomies;
                        }
                        else if (tagValue == "???")
                        {
                            //cS.sR.color = Color.HSVToRGB(0, 0, 40);
                            grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                            charSpeak = speaker.None;
                        }
                        break;
                    case BBUN_TAG:
                        switch (tagValue)
                        {
                            case "Plain":
                                mGC.orderedIngredients[0] = BurgerIngredients.ingredientType.classicBottomBun;
                                manager.DisplayImage(manager.classicBottomBun,1);
                                break;
                            case "Lettucebun":
                                mGC.orderedIngredients[0] = BurgerIngredients.ingredientType.lettuceWrapBottom;
                                manager.DisplayImage(manager.lettuceWrapBottom, 1);
                                break;
                            case "Sourdough":
                                mGC.orderedIngredients[0] = BurgerIngredients.ingredientType.sourdoughBottom;
                                manager.DisplayImage(manager.sourdoughBBun,1);
                                break;
                            case "Pretzel":
                                mGC.orderedIngredients[0] = BurgerIngredients.ingredientType.pretzelBottom;
                                manager.DisplayImage(manager.pretzelBBun, 1);
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
                                manager.DisplayImage(manager.pickles,2);
                                break;
                            case "Relish":
                                mGC.orderedIngredients[1] = BurgerIngredients.ingredientType.relish;
                                manager.DisplayImage(manager.relish, 2);
                                break;
                            case "Plain":
                                mGC.orderedIngredients[1] = BurgerIngredients.ingredientType.wholePickle;
                                manager.DisplayImage(manager.plain, 2);
                                break;
                            case "Peppers":
                                mGC.orderedIngredients[1] = BurgerIngredients.ingredientType.peppers;
                                manager.DisplayImage(manager.peppers, 2);
                                break;

                            default:
                                Debug.LogWarning($"Pickles value {tagValue} has not been recongnized");
                                break;
                        }
                        break;
                    case LETTUCE_TAG:
                        switch (tagValue)
                        {
                            case "Wholeleaf":
                                mGC.orderedIngredients[2] = BurgerIngredients.ingredientType.wholeLeafLettuce;
                                manager.DisplayImage(manager.wholeLeafLettuce, 3);
                                break;
                            case "Chopped":
                                mGC.orderedIngredients[2] = BurgerIngredients.ingredientType.choppedLettuce;
                                manager.DisplayImage(manager.choppedLettuce, 3);
                                break;
                            case "Purple":
                                mGC.orderedIngredients[2] = BurgerIngredients.ingredientType.purple;
                                manager.DisplayImage(manager.purple, 3);
                                break;
                            case "Leaf":
                                mGC.orderedIngredients[2] = BurgerIngredients.ingredientType.aLeaf;
                                manager.DisplayImage(manager.aLeaf, 3);
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
                                manager.DisplayImage(manager.beefPatty, 4);
                                break;
                            case "Vegan":
                                mGC.orderedIngredients[3] = BurgerIngredients.ingredientType.mushroomPatty;
                                manager.DisplayImage(manager.mushroom, 4);
                                break;
                            case "Chicken":
                                mGC.orderedIngredients[3] = BurgerIngredients.ingredientType.chicken;
                                manager.DisplayImage(manager.chicken, 4);
                                break;
                            case "Cheeseburger":
                                mGC.orderedIngredients[3] = BurgerIngredients.ingredientType.withCheese;
                                manager.DisplayImage(manager.cheeseburger, 4);
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
                                manager.DisplayImage(manager.ketchup, 5);
                                break;
                            case "Mustard":
                                mGC.orderedIngredients[4] = BurgerIngredients.ingredientType.mustard;
                                manager.DisplayImage(manager.mustard, 5);
                                break;
                            case "Both":
                                mGC.orderedIngredients[4] = BurgerIngredients.ingredientType.both;
                                manager.DisplayImage(manager.both, 5);
                                break;
                            case "Mayo":
                                mGC.orderedIngredients[4] = BurgerIngredients.ingredientType.mayo;
                                manager.DisplayImage(manager.mayo, 5);
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
                                manager.DisplayImage(manager.tomatoe, 6);
                                break;
                            case "Onion":
                                mGC.orderedIngredients[5] = BurgerIngredients.ingredientType.choppedOnions;
                                manager.DisplayImage(manager.choppedOnions, 6);
                                break;
                            case "Onionrings":
                                mGC.orderedIngredients[5] = BurgerIngredients.ingredientType.onionRings;
                                manager.DisplayImage(manager.onionRings, 6);
                                break;
                            case "Mushrooms":
                                mGC.orderedIngredients[5] = BurgerIngredients.ingredientType.mushrooms;
                                manager.DisplayImage(manager.mushrooms, 6);
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
                                manager.DisplayImage(manager.classicTopBun, 7);
                                break;
                            case "Lettucebun":
                                mGC.orderedIngredients[6] = BurgerIngredients.ingredientType.lettuceWrapTop;
                                manager.DisplayImage(manager.lettuceWrapTop, 7);
                                break;
                            case "Sourdough":
                                mGC.orderedIngredients[6] = BurgerIngredients.ingredientType.sourdoughTop;
                                manager.DisplayImage(manager.sourdoughTBun, 7);
                                break;
                            case "Pretzel":
                                mGC.orderedIngredients[6] = BurgerIngredients.ingredientType.pretzelTop;
                                manager.DisplayImage(manager.pretzelTBun, 7);
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

        public void ExitDialogueMode(bool enterDialogueMode, int day, int csConvoNumber)
        {
            
            dV.StopListening(currentStory);

            //dialogueObject.SetActive(false);
            foreach (GameObject item in dialogueObject)
            {
                item.SetActive(false);
            }

            iEF.unBind(currentStory);
            //currentStory.UnbindExternalFunction("StartBAMicro1");
            convoModeImages.gameObject.SetActive(false);
            dialoguePlaying = false;

            dPTest.enabled = false;

            dialogueText.text = "";
            if(enterDialogueMode)
            {
                EnterDinerMode(day);
            }
            exitedDialogueMode = true;
        }

        public void EnterDinerMode(int day)
        {
            switch (day)//will determine who's avalible
            {
                default:
                    break;
            }
            convoModeImages.gameObject.SetActive(false);
            charBtn.gameObject.SetActive(true);
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
