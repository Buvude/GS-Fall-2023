using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace InterDineMension.Manager
{
    using InterDineMension.Character;
    using JetBrains.Annotations;
    using MicroGame;
    using MicroGame.BA;
    using Unity.VisualScripting;

    //using System.Diagnostics;




    //using UnityEngine.UIElements;

    public class dialogueManager : MonoBehaviour
    {
        internal bool fading = false;
        public Sprite black;
        public Scrollbar sb;
        public GameObject autoText;
        public float autoPauseFloat;
        internal bool autoMode;

        public TextMeshProUGUI historyText;
        public GameObject dialogueHistory;
        internal bool historyShowing = false;
        
        internal GameplayManager gM;
        public List<string> historyLog = new List<string>();
        public GameObject pauseScreen;
        public float fadeInOutRate;
        public AppartmentManager aM;
        public bool useSaveSystem;

        //tags
        public List<string> sfxTittles = new List<string>();
        public List<AudioClip> sfxSounds = new List<AudioClip>();
        public Dictionary<string, AudioClip> sfxLibrary = new Dictionary<string, AudioClip>();
        public AudioSource sfxAudioSource;

        public List<string> bgmTittles = new List<string>();
        public List<AudioClip> bgmSounds = new List<AudioClip>();
        public Dictionary<string, AudioClip> musicLibrary = new Dictionary<string, AudioClip>();
        public AudioSource bgmAudioSource;

        /* public List<string> vOTittles = new List<string>();
         public List<AudioClip> vOSounds = new List<AudioClip>();
         public Dictionary<string, AudioClip> vOLibrary = new Dictionary<string, AudioClip>();
         public AudioSource vOAudioSource;*/ //commented out until VO clips are added

        public List<string> bGTittles = new List<string>();
        public List<Sprite> bGSprites = new List<Sprite>();
        public Dictionary<string, Sprite> bGLibray = new Dictionary<string, Sprite>();
        public Image backgroundImage;

        public List<string> cGTittles = new List<string>();
        public List<Sprite> cGSprites = new List<Sprite>();
        public Dictionary<string, Sprite> cGLibray = new Dictionary<string, Sprite>();
        public Image CGFade;
        
        public List<string> popUpKey = new List<string>();
        public List<Sprite> popUpSprites = new List<Sprite>();
        public Dictionary<string, Sprite> popUpLibrary = new Dictionary<string, Sprite>();

        //public GameObject charImageCS, charImageOR;
        //private bool deactivatedcorutines = false;
        internal VariableHolder vH;
        public GameObject convoModeImages, charBtn;
        public dialogueSpriteManager manager;
        public GameObject[] dialogueObject;
        //tutorial made it a private serializeField, but I want to be able to adjust this with settings
        public float typingSpeed = 0.04f;
        private Coroutine displayLineCorutine;
        internal DialogueVariables dV;
        private bool canContinueToNextLine = false;
       
        public CheffSwatts cS /*= new CheffSwatts()*/;
        public Graciana grac/*=new Graciana()*/;
        public O_Ryan oR;
        public CeeCee cC;
        public Gnomies G;
        public Fred F;
        public Morgan M;
        public Nico N;


        public GameObject cSBtn, oRBtn, cCBtn, gBtn, fBtn, mBtn, nBtn;

        internal bool choicesDisplayed = false;
        public enum speaker { Graciana, Swatts,O_Ryan, CeeCee, Gnomies, Fred, Morgan, Nico, None};
        public enum speakingTo {  O_Ryan, Swatts, CeeCee, Gnomies, Fred, Morgan, Nico};
        public speaker charSpeak;
        public speakingTo charSpeakTo;

        private static dialogueManager instance;

        public GameObject dialoguePanel;


        [SerializeField] private Image dPTest;

        [SerializeField] private TextMeshProUGUI dialogueText;
        [SerializeField] private TextMeshProUGUI displayNameText;
        [SerializeField] private GameObject continueIcon;

        [SerializeField] private GameObject[] choices;

        [SerializeField] public TextAsset IntroOryan;
        [SerializeField] public TextAsset TTMicroArcadeConvo;
        [SerializeField] private TextAsset loadGlobalsJSON;
        
        //internal string savedjson;

        private TextMeshProUGUI[] choicesText;

        private Story currentStory;
        public Story loadGlobalink;

        private bool exitedDialogueMode = false;

        public Microgamecontroller mGC;
        public BAManeger bAM;
        public bool quicksaved = false;
        public bool dialoguePlaying { get; private set; }
        /// <summary>
        /// this is for the BAMicro game
        /// </summary>
        /// 
        //all of the tags
        private const string SPEAKER_TAG = "speaker";
        private const string BBUN_TAG = "BBun";
        private const string PICKLES_TAG = "Pickles";
        private const string LETTUCE_TAG = "lettuce";
        private const string PATTY_TAG = "patty";
        private const string CONDIMENTS_TAG = "Condiments";
        private const string VEGGIE_TAG = "veggie";
        private const string TBUN_TAG = "TBun";
        private const string MOOD = "mood";
        private const string SFX = "sfx";
        private const string BGM = "bgm";
        private const string BG = "bg";
        private const string SCG = "scg";
        private const string ECG = "ecg";
        private const string ESFO = "esfo";
        private const string SS = "ss";
        private const string PU = "pu";
        private const string PD = "pd";
        //private const string VAR_CHANGE = "varChange"; not sure what this was supposed to me lmao

        public InkExternalFunctions iEF;
        public GameObject BBun2, Pickles2, Greens2, Patty2, Condiment2, Veggie2, TBun2;
        public GameObject BBun3, Pickles3, Greens3, Patty3, Condiment3, Veggie3, TBun3;
        internal bool morning;
        private void Awake()
        { 
            
            if (sfxTittles.Count == sfxSounds.Count)
            {
                for (int i = 0; i < sfxTittles.Count; i++)
                {
                    sfxLibrary.Add(sfxTittles[i], sfxSounds[i]);
                }
            }
            else
            {
                Debug.LogError("sfxTittles and sfxSounds are not at an equal count");
            }
            if (bgmTittles.Count == bgmSounds.Count)
            {
                for (int i = 0; i < bgmTittles.Count; i++)
                {
                    musicLibrary.Add(bgmTittles[i], bgmSounds[i]);
                }
            }
            else
            {
                Debug.LogError("bgmTittles and bgmSounds are not at an equal count");
            }

            if (bGTittles.Count == bGSprites.Count)
            {
                for (int i = 0; i < bGTittles.Count; i++)
                {
                    bGLibray.Add(bGTittles[i], bGSprites[i]);
                }
            }
            else
            {
                Debug.LogError("bGTittles and bGSprites are not at an equal count");
            }

            if (popUpKey.Count == popUpSprites.Count)
            {
                for (int i = 0; i < popUpKey.Count; i++)
                {
                    popUpLibrary.Add(popUpKey[i], popUpSprites[i]);
                }
            }
            else
            {
                Debug.LogError("bGTittles and bGSprites are not at an equal count");
            }
            currentStory = new Story(loadGlobalsJSON.text);

            GameObject[] tempList = GameObject.FindGameObjectsWithTag("variableHolder");
            foreach (GameObject temp in tempList)
            {
                temp.GetComponent<VariableHolder>().dM = this;
            }
            if (cGTittles.Count == cGSprites.Count)
            {
                for (int i = 0; i < cGTittles.Count; i++)
                {
                    cGLibray.Add(cGTittles[i], cGSprites[i]);
                }
            }
            else
            {
                Debug.LogError("sfxTittles and sfxSounds are not at an equal count");
            }

            /* cS.sR.color = Color.HSVToRGB(0, 0, 40);*/
            grac.sR.color = Color.HSVToRGB(0, 0, 40);
            iEF = new InkExternalFunctions(BBun2, Pickles2, Greens2, Patty2, Condiment2, Veggie2, TBun2, BBun3, Pickles3, Greens3, Patty3, Condiment3, Veggie3, TBun3);
            dPTest = this.gameObject.GetComponent<Image>();
            dV = new DialogueVariables(currentStory);
            if (PlayerPrefs.GetString("currentConvo")!="practiceT"&&PlayerPrefs.GetString("currentConvo")!="practiceB"&&PlayerPrefs.GetString("currentConvo")!="finale")
            {
                if (PlayerPrefs.GetString("timeOfDay") == "Apt")
                {
                    QuickLoad();
                }
                else if (PlayerPrefs.GetString("timeOfDay") == "morning")
                {

                    if (PlayerPrefs.GetString("newGame") != "false") { Debug.Log("quicksave lacation test"); PPSave(); QuickLoad(); }
                    else { QuickSave(); }
                }

                //QuickSave();
                if (PlayerPrefs.GetString("newGame").Equals("false") && PlayerPrefs.GetString("timeOfDay") == "morning")
                {
                    Debug.Log("test");
                    useSaveSystem = true;
                    //Debug.Log("Using save system");
                    dV.LoadVariables();
                    PPSave();
                }
            }
            PlayerPrefs.SetString("newGame", "false");

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
            gM = GameObject.FindGameObjectWithTag("variableHolder").GetComponent<GameplayManager>();
            GameObject.FindGameObjectWithTag("variableHolder").GetComponent<GameplayManager>().manager = this;

            vH = GameObject.FindGameObjectWithTag("variableHolder").GetComponent<VariableHolder>();
            //conditional of what state the day is in
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
            {
                if (PlayerPrefs.GetString("timeOfDay") == "morning")
                {
                    StartMorningConvo();//will need to be adjusted later
                }
                else if (PlayerPrefs.GetString("timeOfDay") == "afternoon")
                {
                    PostMiniGameConvo();
                }
                else if (PlayerPrefs.GetString("timeOfDay") == "night")
                {
                    //night time activity
                }
                else
                {
                    Debug.LogWarning("The variable timeOfDay in globals.ink is not in a valid state");
                }
            }
            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
            {
                charSpeakTo = speakingTo.Swatts;
                EnterDialogueMode(IntroOryan);
            }
            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5))
            {
                aM = GameObject.FindGameObjectWithTag("eventSystem").GetComponent<AppartmentManager>();
                charSpeakTo = speakingTo.Swatts;
                aM.dM = this;
                QuickLoad();
                //QuickSave();
                if (PlayerPrefs.GetString("currentConvo") != "practiceB"&&PlayerPrefs.GetString("currentConvo")!="practiceT")
                {
                    EnterDialogueMode(aM.appartmentIntro);
                }
                else
                {
                    if (PlayerPrefs.GetString("currentConvo") == "practiceT")
                    {
                        EnterDialogueMode(aM.postTTMPractice);
                    }
                    else if (PlayerPrefs.GetString("currentConvo") == "practiceB")
                    {
                        EnterDialogueMode(aM.postBAMPractice);
                    }
                    //EnterDialogueMode
                }
                
                
            }
           

           
            
        }
        public void UnPauseGame()
        {
            GameObject.FindGameObjectWithTag("variableHolder").GetComponent<GameplayManager>().paused = false;
        }
        public void QuitGame()
        {
            Application.Quit();
        }

        public void MainMenu()
        {
            GameObject.FindGameObjectWithTag("variableHolder").GetComponent<GameplayManager>().paused=false;
            dV.clearTempVars(vH);
            if (bAM != null)
            {
                //bAM.ResetMiniGame();
            }
            SceneManager.LoadScene(0);
        }
        public void QuickSave()
        {

            quicksaved = true;
            /* savedjson = currentStory.state.ToJson();
             PlayerPrefs.SetString("savedjson", savedjson);*/
            dV.QuickSaveVariables();
        }
        public void PPSave()
        {
            quicksaved = true;
            dV.PPSave();

        }

        public void QuickLoad()
        {
            dV.globalVariablesStory = currentStory;
            dV.QuickLoadVariables();
        }
        public void StartMorningConvo()
        {
            charSpeakTo = speakingTo.Swatts;
            if (PlayerPrefs.GetInt("convo_numberOR") == 5)
            {
                cS.sR.sprite = cS.CsspriteDictionary["neutral"];
                PlayerPrefs.SetString("weekDay", "Fin");
                QuickLoad();
                EnterDialogueMode(cS.CsdialogueDictionary["CSFinale"]);
            }
            else
            {
                switch (PlayerPrefs.GetInt("dayVarT"))//so it defaults to the random quip thing unless there is something specific for CS to say today
                {
                    case 0:
                        PlayerPrefs.SetString("weekDay", "Tut");
                        EnterDialogueMode(cS.CsdialogueDictionary["gameIntro"]);
                        break;
                    default:

                        /* EnterDialogueMode(cS.ORdialogueDictionary["morning"]);*/
                        morning = true;
                        cS.sR.sprite= cS.CsspriteDictionary["neutral"];
                        
                        EnterDialogueMode(cS.CsdialogueDictionary[PlayerPrefs.GetString("weekDay")]);
                        break;
                }
            }
            

            
        }

        public void PostMiniGameConvo()
        {
            switch (PlayerPrefs.GetString("currentConvo"))
            {
                case "GMG3":
                    charSpeakTo = speakingTo.CeeCee;
                    G.gameObject.SetActive(true);
                    EnterDialogueMode(G.GdialogueDictionary["postMini"]);
                    break;
                case "FMG3":
                    charSpeakTo = speakingTo.CeeCee;
                    F.gameObject.SetActive(true);
                    EnterDialogueMode(F.FdialogueDictionary["postMini"]);
                    break;
                case "NMG1":
                    charSpeakTo = speakingTo.CeeCee;
                    N.gameObject.SetActive(true);
                    EnterDialogueMode(N.NdialogueDictionary["postMini"]);
                    break;
                case "NMG2":
                    charSpeakTo = speakingTo.CeeCee;
                    N.gameObject.SetActive(true);
                    EnterDialogueMode(N.NdialogueDictionary["postMini"]);
                    break;
                case "NMG3":
                    charSpeakTo = speakingTo.CeeCee;
                    N.gameObject.SetActive(true);
                    EnterDialogueMode(N.NdialogueDictionary["postMini"]);
                    break;
                case "MMG1":
                    charSpeakTo = speakingTo.CeeCee;
                    mBtn.gameObject.SetActive(true);
                    EnterDialogueMode(M.MdialogueDictionary["postMini"]);
                    break;
                case "MMG3":
                    charSpeakTo = speakingTo.CeeCee;
                    M.gameObject.SetActive(true);
                    EnterDialogueMode(M.MdialogueDictionary["postMini"]);
                    break;
                case "finale":
                    {
                        charSpeakTo = speakingTo.O_Ryan;
                        //QuickLoad();
                        switch (PlayerPrefs.GetString("winStatus"))
                        {
                            case "won":
                                EnterDialogueMode(oR.ORdialogueDictionary["finalTTPass"]);
                                break;
                            case "lost":
                                EnterDialogueMode(oR.ORdialogueDictionary["finalTTFail"]);
                                break;
                            case "chaos":
                                EnterDialogueMode(oR.ORdialogueDictionary["finalTTChaos"]);
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                default:
                    break;
            }
           
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
            if(!choicesDisplayed&& (canContinueToNextLine && currentStory.currentChoices.Count==0&&(Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Z)||Input.GetKey(KeyCode.RightControl))))            {
                if(autoMode)
                {
                    autoText.SetActive(false);
                    autoMode = false;
                }
                ContinueStory();
            }
            if (Input.GetMouseButtonDown(2)||Input.GetKeyDown(KeyCode.Tab))
            {
                if(historyShowing)
                {
                    dialogueHistory.SetActive(false);
                    historyShowing = false;
                }
                else
                {
                    autoMode = false;
                    historyShowing = true;
                    dialogueHistory.SetActive(true);
                }
            }
            if(Input.GetKeyDown(KeyCode.A)&&!gM.paused&&!choicesDisplayed)
            {
                if(!autoMode&&!historyShowing)
                {
                    autoText.SetActive(true);
                    autoMode = true;
                    if(canContinueToNextLine)
                    {
                        ContinueStory();
                    }
                }
                else
                {
                    autoText.SetActive(false);
                    autoMode = false;
                }
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
        public void setCharSpeakToOR()
        {
            charSpeakTo = speakingTo.O_Ryan;
        }
        public void setCharSpeakToCC()
        {
            charSpeakTo = speakingTo.CeeCee;
        }
        public void setCharSpeakToG()
        {
            charSpeakTo = speakingTo.Gnomies;
        }
        public void setCharSpeakToF()
        {
            charSpeakTo = speakingTo.Fred;
        }
        public void setCharSpeakToM()
        {
            charSpeakTo = speakingTo.Morgan;
        }
        public void setCharSpeakToN()
        {
            charSpeakTo = speakingTo.Nico;
        }

        public void EnterDialogueModeBTN()
        {
            switch (charSpeakTo)
            {
                case speakingTo.O_Ryan:
                    PlayerPrefs.SetString("currentConvo", "finale");
                    QuickLoad();
                    oR.sR.sprite = oR.ORspriteDictionary["neutral"];
                    EnterDialogueMode(oR.ORdialogueDictionary["final"]);
                    break;
                case speakingTo.Swatts:
                    {
                        switch (PlayerPrefs.GetInt("convo_numberCST"))
                        {
                            case 0:
                                {
                                    morning = false;
                                    EnterDialogueMode(cS.CsdialogueDictionary["cSTalkTo1"]);
                                    break;
                                }
                            case 1:
                                {
                                    morning = false;
                                    
                                    EnterDialogueMode(cS.CsdialogueDictionary["cSTalkTo2"]);
                                    break;
                                }
                            case 2:
                                {
                                    morning = false;
                                    EnterDialogueMode(cS.CsdialogueDictionary["cSTalkTo3"]);
                                    break;
                                }
                            case >=3:
                                {
                                    morning = false;
                                    EnterDialogueMode(cS.CsdialogueDictionary["brushOff"]);
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                    break;
                case speakingTo.CeeCee:
                    switch (PlayerPrefs.GetInt("convo_numberCCT"))
                    {
                        case 0:
                            {
                                EnterDialogueMode(cCBtn.gameObject.GetComponent<CeeCee>().CcdialogueDictionary["CCTalkTo1"]);
                                break;
                            }
                        case 1:
                            {
                                EnterDialogueMode(cCBtn.gameObject.GetComponent<CeeCee>().CcdialogueDictionary["CCTalkTo2"]);
                                break;
                            }
                        case 2:
                            {
                                EnterDialogueMode(cCBtn.gameObject.GetComponent<CeeCee>().CcdialogueDictionary["CCTalkTo3"]);
                                break;
                            }
                        case 3:
                            {
                                EnterDialogueMode(cCBtn.gameObject.GetComponent<CeeCee>().CcdialogueDictionary["CCEndings"]);
                                break;
                            }
                        case >=4:
                            {
                                EnterDialogueMode(cCBtn.gameObject.GetComponent<CeeCee>().CcdialogueDictionary["brushOff"]);
                                break;
                            }
                        default:
                            break;
                    }
                    break;
                case speakingTo.Gnomies:
                    switch (PlayerPrefs.GetInt("convo_numberGT"))
                    {
                        case 0:
                            {
                                EnterDialogueMode(gBtn.gameObject.GetComponent<Gnomies>().GdialogueDictionary["GIntro"]);
                                break;
                            }
                        case 1:
                            {
                                EnterDialogueMode(gBtn.gameObject.GetComponent<Gnomies>().GdialogueDictionary["GTalkTo2"]);
                                break;
                            }
                        case 2:
                            {
                                EnterDialogueMode(gBtn.gameObject.GetComponent<Gnomies>().GdialogueDictionary["GTalkTo3"]);
                                break;
                            }
                        case 3:
                            {
                                EnterDialogueMode(gBtn.gameObject.GetComponent<Gnomies>().GdialogueDictionary["GEndings"]);
                                break;
                            }
                        case >=4:
                            {
                                EnterDialogueMode(gBtn.gameObject.GetComponent<Gnomies>().GdialogueDictionary["brushOff"]);
                                break;
                            }
                        default:
                            break;
                    }break;
                case speakingTo.Fred:
                    switch (PlayerPrefs.GetInt("convo_numberFT"))
                    {
                        case 0:
                            {
                                EnterDialogueMode(fBtn.gameObject.GetComponent<Fred>().FdialogueDictionary["FIntro"]);
                                break;
                            }
                        case 1:
                            {
                                EnterDialogueMode(fBtn.gameObject.GetComponent<Fred>().FdialogueDictionary["FTalkTo2"]);
                                break;
                            }
                        case 2:
                            {
                                EnterDialogueMode(fBtn.gameObject.GetComponent<Fred>().FdialogueDictionary["FTalkTo3"]);
                                break;
                            }
                        case 3:
                            {
                                EnterDialogueMode(fBtn.gameObject.GetComponent<Fred>().FdialogueDictionary["FEndings"]);
                                break;
                            }
                        case >=4:
                            {
                                EnterDialogueMode(fBtn.gameObject.GetComponent<Fred>().FdialogueDictionary["brushOff"]);
                                break;
                            }
                        default:
                            Debug.Log("test");
                            break;
                    }
                    break;
                case speakingTo.Morgan:
                    switch (PlayerPrefs.GetInt("convo_numberMT"))
                    {
                        case 0:
                            {
                                EnterDialogueMode(mBtn.gameObject.GetComponent<Morgan>().MdialogueDictionary["MTalkTo1"]);
                                break;
                            }
                        case 1:
                            {
                                EnterDialogueMode(mBtn.gameObject.GetComponent<Morgan>().MdialogueDictionary["MTalkTo2"]);
                                break;
                            }
                        case 2:
                            {
                                EnterDialogueMode(mBtn.gameObject.GetComponent<Morgan>().MdialogueDictionary["MTalkTo3"]);
                                break;
                            }
                        case 3:
                            {
                                EnterDialogueMode(mBtn.gameObject.GetComponent<Morgan>().MdialogueDictionary["MEndings"]);
                                break;
                            }
                        case >=4:
                            {
                                EnterDialogueMode(mBtn.gameObject.GetComponent<Morgan>().MdialogueDictionary["brushOff"]);
                                break;
                            }
                        default:
                            break;
                    }
                    break;
                case speakingTo.Nico:
                    switch (PlayerPrefs.GetInt("convo_numberNT"))
                    {
                        case 0:
                            {
                                    morning = false;
                                convoModeImages.SetActive(true);
                                PlayerPrefs.SetString("currentConvo", "NMG1");
                                EnterDialogueMode(nBtn.gameObject.GetComponent<Nico>().NdialogueDictionary["NicoIntro"]);
                                break;
                            }
                        case 1:
                            {
                                    morning = false;
                                convoModeImages.SetActive(true);
                                PlayerPrefs.SetString("currentConvo", "NMG2");
                                EnterDialogueMode(nBtn.gameObject.GetComponent<Nico>().NdialogueDictionary["NTalkTo2"]);
                                break;
                            }
                        case 2:
                            {
                                    morning = false;
                                convoModeImages.SetActive(true);
                                PlayerPrefs.SetString("currentConvo", "NMG3");
                                EnterDialogueMode(nBtn.gameObject.GetComponent<Nico>().NdialogueDictionary["NTalkTo3"]);
                                break;
                            }
                        case 3:
                            {
                                EnterDialogueMode(nBtn.gameObject.GetComponent<Nico>().NdialogueDictionary["NEndings"]);
                                break;
                            }
                        case >=4:
                            {
                                EnterDialogueMode(nBtn.gameObject.GetComponent<Nico>().NdialogueDictionary["brushOff"]);
                                break;
                            }
                        default:
                            break;
                    }
                    break;
                default:
                    break;
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
            if (!morning)
            {
                if (quicksaved)
                {/*
                    if (PlayerPrefs.GetString("weekDayT") == "Tut")
                    {
                        QuickSave();
                    }
                    else { PPSave(); }*/
                    QuickSave();
                }
                currentStory = new Story(inkJSON.text);
                if (quicksaved)
                {
                    QuickLoad();
                }
            }
            else
            {
                //QuickSave();
                currentStory = new Story(inkJSON.text);
                //QuickLoad();
            }

            
            vH.currentStory = currentStory;
            dialoguePlaying=true;
            if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(5))
            {
                grac.gameObject.GetComponent<Image>().enabled = true;
            }
                
            //dV.StartListening(currentStory);
            if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(5))
            {
                switch (charSpeakTo)
                {
                    case speakingTo.O_Ryan:
                        oR.gameObject.SetActive(true);
                        G.gameObject.SetActive(false);
                        cS.gameObject.SetActive(false);
                        cC.gameObject.SetActive(false);
                        F.gameObject.SetActive(false);
                        N.gameObject.SetActive(false);
                        M.gameObject.SetActive(false);
                        break;
                    case speakingTo.Swatts:
                        oR.gameObject.SetActive(false);
                        G.gameObject.SetActive(false);
                        cS.gameObject.SetActive(true);
                        cC.gameObject.SetActive(false);
                        F.gameObject.SetActive(false);
                        N.gameObject.SetActive(false);
                        M.gameObject.SetActive(false);
                        break;
                    case speakingTo.CeeCee:
                        oR.gameObject.SetActive(false);
                        G.gameObject.SetActive(false);
                        cS.gameObject.SetActive(false);
                        cC.gameObject.SetActive(true);
                        F.gameObject.SetActive(false);
                        N.gameObject.SetActive(false);
                        M.gameObject.SetActive(false);
                        break;
                    case speakingTo.Gnomies:
                        oR.gameObject.SetActive(false);
                        G.gameObject.SetActive(true);
                        cS.gameObject.SetActive(false);
                        cC.gameObject.SetActive(false);
                        F.gameObject.SetActive(false);
                        N.gameObject.SetActive(false);
                        M.gameObject.SetActive(false);
                        break;
                    case speakingTo.Fred:
                        oR.gameObject.SetActive(false);
                        G.gameObject.SetActive(false);
                        cS.gameObject.SetActive(false);
                        cC.gameObject.SetActive(false);
                        F.gameObject.SetActive(true);
                        N.gameObject.SetActive(false);
                        M.gameObject.SetActive(false);
                        break;
                    case speakingTo.Nico:
                        oR.gameObject.SetActive(false);
                        G.gameObject.SetActive(false);
                        cS.gameObject.SetActive(false);
                        cC.gameObject.SetActive(false);
                        F.gameObject.SetActive(false);
                        N.gameObject.SetActive(true);
                        M.gameObject.SetActive(false);
                        break;
                    case speakingTo.Morgan:
                        oR.gameObject.SetActive(false);
                        G.gameObject.SetActive(false);
                        cS.gameObject.SetActive(false);
                        cC.gameObject.SetActive(false);
                        F.gameObject.SetActive(false);
                        N.gameObject.SetActive(false);
                        M.gameObject.SetActive(true);
                        break;
                    default:
                        break;
                }
            }
            

            /*currentStory.BindExternalFunction("StartBAMicro", () =>
            {
                 Debug.Log("called StartBAMicro");
             });*/

            iEF.Bind(currentStory,bAM,mGC,this);
            vH.currentStory = currentStory;
            morning = false;

            ContinueStory();
        }

        
        /// <summary>
        /// this is a a function that will be called by the debug button to do any number of things.
        /// </summary>
        public void debugCommand()
        {
            
            EnterDialogueMode(IntroOryan);
        }

        private void ContinueStory()
        {

            if (currentStory.canContinue&& !gM.paused&&!historyShowing)
            {
                //set text for current dialogue line
                if (displayLineCorutine != null)
                {

                    //oR.sR.sprite = oR.ORspriteDictionary["neutral"];

                    StopCoroutine(displayLineCorutine);
                    //oR.sR.sprite = oR.ORspriteDictionary["neutral"];


                }
                if (historyLog.Count > 0)
                {
                    //string temp=historyText.text.ToString();
                    historyText.text = $"{charSpeak.ToString()}: {historyLog[historyLog.Count-1]}" +
                        $" {historyText.text.ToString()}";
                }
                
                displayLineCorutine = StartCoroutine(DisplayLine(currentStory.Continue()));
                /*dialogueText.text = currentStory.Continue(); outdated*/
                HandleTags(currentStory.currentTags);
                //Debug.Log(currentStory.currentChoices.Count);



            }

            else if(!gM.paused&&!historyShowing)
            {

                ExitDialogueMode(false,0,"ContinueStory",true);
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
            if (line != "")
            {
                
                if(historyLog.Count > 0)
                {
                    if(line != historyLog[historyLog.Count - 1])
                    {
                        historyLog.Add(line);
                    }
                }
                else
                {
                    historyLog.Add(line);
                }
            }
            
            //display each letter one at a time. 
            foreach(char letter in line.ToCharArray())
            {
                //if the submit button is pressed, finish up displaying the line right away
                if (Input.GetKey(KeyCode.RightControl)&&!fading)
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
            
            
            if (autoMode&&canContinueToNextLine)
            {
                yield return new WaitForSeconds(autoPauseFloat);
                if(autoMode&&canContinueToNextLine)
                {
                    ContinueStory();
                }
            }
            yield return new WaitForEndOfFrame();
        }

        private void Hidechoices()
        {
            choicesDisplayed = false;
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
                if(splitTag.Length == 3)
                {
                    if (splitTag[0] == "ss")
                    {
                        string tagKeyT = splitTag[1].Trim();
                        string tagValueT = splitTag[2].Trim();
                        if (tagKeyT == "Chef Swatts")
                        {
                            cS.sR.sprite = cS.CsspriteDictionary[tagValueT];
                            return;
                        }
                        else if (tagKeyT == "Graciana")
                        {
                            grac.sR.sprite = grac.GrspriteDictionary[tagValueT];
                            return;
                        }
                        else if (tagKeyT == "O'Ryan")
                        {
                            oR.sR.sprite = oR.ORspriteDictionary[tagValueT];
                            return;
                        }
                        else if (tagKeyT == "CeCe")
                        {
                            cC.sR.sprite = cC.CcspriteDictionary[tagValueT];
                            return;
                        }
                        else if (tagKeyT == "Himber" || tagValueT == "Hograt")
                        {
                            G.sR.sprite = G.GspriteDictionary[tagValueT];
                            return;
                        }
                        else if (tagKeyT == "Fred")
                        {
                            F.sR.sprite = F.FspriteDictionary[tagValueT];
                            return;
                        }
                        else if (tagKeyT == "Morgan")
                        {
                            M.sR.sprite = M.MspriteDictionary[tagValueT];
                            return;
                        }
                        else if (tagKeyT == "NiCo")
                        {
                            N.sR.sprite = N.NspriteDictionary[tagValueT];
                            return;
                        }
                        else if (tagKeyT == "spotlight")
                        {
                            switch (tagValueT)
                            {//this should make it so when someone is talking with a "???" name plate they can still be in the spotlight
                                case "O'Ryan":
                                    charSpeakTo = speakingTo.O_Ryan;
                                    oR.sR.color = Color.HSVToRGB(0, 0, 1f, false);
                                    oR.gameObject.SetActive(true);
                                    return;
                                case "Chef Swatts":
                                    charSpeakTo = speakingTo.Swatts;
                                    cS.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    cS.gameObject.SetActive(true);
                                    return;
                                case "CeCe":
                                    charSpeakTo = speakingTo.CeeCee;
                                    cC.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    cC.gameObject.SetActive(true);
                                    return;
                                case "Himber":
                                    charSpeakTo = speakingTo.Gnomies;
                                    G.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    G.gameObject.SetActive(true);
                                    return;
                                case "Hograt":
                                    charSpeakTo = speakingTo.Gnomies;
                                    G.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    G.gameObject.SetActive(true);
                                    return;
                                case "Fred":
                                    charSpeakTo = speakingTo.Fred;
                                    F.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    F.gameObject.SetActive(true);
                                    return;
                                case "Morgan":
                                    charSpeakTo = speakingTo.Morgan;
                                    M.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    M.gameObject.SetActive(true);
                                    return;
                                case "NiCo":
                                    charSpeakTo = speakingTo.Nico;
                                    N.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                    N.gameObject.SetActive(true);
                                    return;
                                default:
                                    grac.sR.color = Color.HSVToRGB(0, 0, 1, true);
                                    return;
                            }
                    }
                        else
                        {
                            Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                            return;
                        }
                    }
                    
                }
                else if (splitTag.Length != 2)
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

                                        grac.sR.sprite = grac.GrspriteDictionary[tagValue];                                        
                                        break;
                                    }
                                    
                                case speaker.Swatts:
                                    {
                                        cS.sR.sprite = cS.CsspriteDictionary[tagValue];
                                        break;
                                    }
                                case speaker.O_Ryan:
                                    {
                                        oR.sR.sprite = oR.ORspriteDictionary[tagValue];
                                        break;
                                    }
                                case speaker.CeeCee:
                                    {
                                        cC.sR.sprite = cC.CcspriteDictionary[tagValue];
                                        break;
                                    }
                                case speaker.Gnomies:
                                    {
                                        G.sR.sprite = G.GspriteDictionary[tagValue];
                                        break;
                                    }
                                case speaker.Fred:
                                    F.sR.sprite= F.FspriteDictionary[tagValue];
                                    break;
                                case speaker.Morgan:
                                    M.sR.sprite= M.MspriteDictionary[tagValue];
                                    break;
                                case speaker.Nico:
                                    N.sR.sprite = N.NspriteDictionary[tagValue];
                                    break;
                                case speaker.None:
                                    break;
                                default:
                                    break;
                            }break;
                        }
                    case SPEAKER_TAG:
                        {
                            displayNameText.text = tagValue;
                            if (tagValue == "Chef Swatts")
                            {
                                cS.sR.color = Color.HSVToRGB(0, 0, 1, true);
                                grac.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                charSpeakTo = speakingTo.Swatts;
                                charSpeak = speaker.Swatts;
                            }
                            else if (tagValue == "Graciana")
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
                                        grac.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                        break;
                                    case speakingTo.CeeCee:
                                        cC.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                        grac.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                        break;
                                    case speakingTo.Gnomies:
                                        G.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                        grac.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                        break;
                                    case speakingTo.Fred:
                                        F.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                        grac.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                        break;
                                    case speakingTo.Morgan:
                                        M.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                        grac.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                        break;
                                    case speakingTo.Nico:
                                        N.sR.color = Color.HSVToRGB(0, 0, .4f, false);
                                        grac.sR.color = Color.HSVToRGB(0, 0, 1, false);
                                        break;
                                    default:
                                        grac.sR.color = Color.HSVToRGB(0, 0, 1, true);
                                        break;
                                    }
                                }
                            else if (tagValue == "O'Ryan")
                            {
                                oR.sR.color = Color.HSVToRGB(0, 0, 1);
                                grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                                charSpeakTo = speakingTo.O_Ryan;
                                charSpeak = speaker.O_Ryan;
                            }
                            else if (tagValue == "CeCe")
                            {
                                cC.sR.color = Color.HSVToRGB(0, 0, 1);
                                grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                                charSpeakTo = speakingTo.CeeCee;
                                charSpeak = speaker.CeeCee;
                            }
                            else if (tagValue == "Himber"||tagValue=="Hograt"||tagValue=="Gnomies")
                            {
                                G.sR.color = Color.HSVToRGB(0, 0, 1);
                                grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                                charSpeakTo = speakingTo.Gnomies;
                                charSpeak = speaker.Gnomies;
                            }
                            else if (tagValue == "Fred")
                            {
                                F.sR.color = Color.HSVToRGB(0, 0, 1);
                                grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                                charSpeakTo = speakingTo.Fred;
                                charSpeak = speaker.Fred;
                            }
                            else if (tagValue == "Morgan")
                            {
                                M.sR.color = Color.HSVToRGB(0, 0, 1);
                                grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                                charSpeakTo = speakingTo.Morgan;
                                charSpeak = speaker.Morgan;
                            }
                            else if (tagValue == "NiCo")
                            {
                                N.sR.color = Color.HSVToRGB(0, 0, 1);
                                grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                                charSpeakTo = speakingTo.Nico;
                                charSpeak = speaker.Nico;
                            }
                            else if (tagValue == "???"||tagValue=="window"||tagValue=="blobster")
                            {
                                //cS.sR.color = Color.HSVToRGB(0, 0, 40);
                                grac.sR.color = Color.HSVToRGB(0, 0, .4f);
                                charSpeak = speaker.None;
                            }
                            else
                            {
                                Debug.LogWarning($"parsing the speaker tag \"{tagValue}\" ");
                            }
                            break;
                        }
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
                            case "OnionRings":
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
                    case SFX:
                        {
                            sfxAudioSource.clip = sfxLibrary[tagValue];
                            sfxAudioSource.Play();
                            break;
                        }
                    case BG:
                        {
                            backgroundImage.sprite = bGLibray[tagValue];
                            break;
                        }
                    case BGM:
                        {
                            if (tagValue == "none")
                            {
                                StartCoroutine(musicFadeIn(null));
                                return;
                            }
                            StartCoroutine(musicFadeIn(musicLibrary[tagValue]));
                            break;
                        }
                    case SCG:
                        {
                            StartCoroutine(CGFadeIn(cGLibray[tagValue]));
                            break;
                        }
                    case ECG:
                        {
                            
                            if (cGLibray.ContainsKey(tagValue))
                            {
                                StartCoroutine(CGFadeOut(bGLibray[tagValue]));
                            }
                            else
                            {
                                StartCoroutine(CGFadeOut(null));
                            }
                            
                            break;
                        }
                    case ESFO:
                        {
                            StartCoroutine(EndSceneFadeOut(false));
                            break;
                        }
                    case PU:
                        {
                            manager.imagePopUpParent.gameObject.SetActive(true);
                            manager.imagePopUp.sprite = popUpLibrary[tagValue];
                            break;
                        }
                    case PD:
                        {
                            manager.imagePopUpParent.gameObject.SetActive(false);
                            break;
                        }
                    default:
                        Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                        break;
                }
            }
        }
        public void musicBAM()
        {
            musicFadeIn(musicLibrary["BAM"]);
        }
        public void afternoonMusic()
        {
            musicFadeIn(musicLibrary["dinDay"]);
        }
        public IEnumerator CGFadeIn(Sprite temp)
        {
            fading = true;
            CGFade.gameObject.SetActive(true);
            CGFade.sprite= temp;
            for (float a = 0; a <= 1.1; a+=.01f)
            {
                yield return new WaitForSeconds(.01f);
                CGFade.color = new UnityEngine.Color(1, 1, 1, a);
            }
            fading = false;
            //CGFade.color = new UnityEngine.Color(0, 0, 0, 1);
        }
        public void ttmStart()
        {
            StartCoroutine(EndSceneFadeOut(true));
        }
        public IEnumerator EndSceneFadeOut(bool ttm)
        {
            Debug.Log("test");
            fading = true;
            CGFade.gameObject.SetActive(true);
            CGFade.sprite = black;
            for (float a = 0; a <= 1.1; a += .01f)
            {
                yield return new WaitForSeconds(.01f);
                CGFade.color = new UnityEngine.Color(0, 0, 0, a);
            }
            //CGFade.color = new UnityEngine.Color(0, 0, 0, 1);
            if( ttm )
            {
                mGC.loadTTM();
            }
            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
            {
                PlayerPrefs.SetString("timeOfDay", "Night");
                SaveGame();
                SceneManager.LoadScene(5);
            }
            else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5))
            {
                SceneManager.LoadScene(1);
            }
        }

        public IEnumerator CGFadeOut(Sprite temp)
        {
            fading = true;
            if(temp!=null)
            {
                backgroundImage.sprite = temp;
            }
            
            for (float a = 1; a >= -0.1; a -= .01f)
            {
                yield return new WaitForSeconds(.01f);
                CGFade.color = new UnityEngine.Color(1, 1, 1, a);
            }
            CGFade.gameObject.SetActive(false);
            //CGFade.color = new UnityEngine.Color(0, 0, 0, 1);
            fading = false;
        }
        public IEnumerator musicFadeIn(AudioClip temp)
        {
            while (bgmAudioSource.volume > 0)
            {
                yield return new WaitForSeconds(.1f);
                bgmAudioSource.volume -= fadeInOutRate;
            }
            if (temp == null)
            {
                yield break;
            }
            bgmAudioSource.clip = temp;
            bgmAudioSource.Play();
            while(bgmAudioSource.volume < 1)
            {
                yield return new WaitForSeconds(.1f);
                bgmAudioSource.volume += fadeInOutRate;
            }
        }
        public void ExitDialogueMode(bool enterDinnerMode, int day, string whereCameFrom, bool quickSave)
        {
            //Debug.Log($"Got to exit dialogue mode from {whereCameFrom} ");
            //dV.StopListening(currentStory);
            if (quickSave)
            {
                //dV = new DialogueVariables(currentStory);
                QuickSave();
            }
            
            if (enterDinnerMode)
            {
                EnterDinerMode(day);
            }
            //dialogueObject.SetActive(false);
            foreach (GameObject item in dialogueObject)
            {
                item.SetActive(false);
            }
            historyLog.RemoveAt(historyLog.Count - 1);
            /*cS.sR.sprite = cS.CsspriteDictionary["blank"];
            cC.sR.sprite = cC.CcspriteDictionary["blank"];
            G.sR.sprite = G.GspriteDictionary["blank"];
            F.sR.sprite = F.FspriteDictionary["blank"];
            M.sR.sprite = M.MspriteDictionary["blank"];
            N.sR.sprite = N.NspriteDictionary["blank"];*/
            iEF.unBind(currentStory);
            //currentStory.UnbindExternalFunction("StartBAMicro1");
            convoModeImages.gameObject.SetActive(false);
            dialoguePlaying = false;

            dPTest.enabled = false;

            dialogueText.text = "";
            
            exitedDialogueMode = true;
        }

        public void EnterDinerMode(int day)
        {
            bool nicoGone = false, fredGone = false, ceceGone = false, gnomiesGone = false;
            if (PlayerPrefs.GetInt("convo_numberN") >= 4 && PlayerPrefs.GetInt("chaosN") >= 12) //if NiCo has reached the bad ending
            {
                nicoGone = true;
            }
            if (PlayerPrefs.GetInt("convo_numberF") >= 4 && PlayerPrefs.GetInt("affectionF") < 0) //if Fred has reached the bad ending
            {
                fredGone = true;
            }
            if (PlayerPrefs.GetInt("convo_numberCC") >= 4 && PlayerPrefs.GetInt("affectionCC") < 0) //if CeCe has reached the bad ending
            {
                ceceGone = true;
            }
            if (PlayerPrefs.GetInt("convo_numberG") >= 4 && (PlayerPrefs.GetInt("affectionG") < 0||PlayerPrefs.GetInt("chaosG")>=14)) //if Gnomies have reached the bad ending or chaos ending
            {
                gnomiesGone = true;
            }
            cSBtn.gameObject.SetActive(false);
            oRBtn.gameObject.SetActive(false); 
            cCBtn.SetActive(false);
            gBtn.SetActive(false);
            fBtn.SetActive(false);
            mBtn.SetActive(false);
            nBtn.SetActive(false);
            charBtn.SetActive(true);
            if (PlayerPrefs.GetString("newGame") != "false") { Debug.Log("quicksave lacation test"); PPSave(); }
            Debug.Log(PlayerPrefs.GetString("weekDayT"));
            switch (PlayerPrefs.GetString("weekDay"))//will determine who's avalible
            {
                case "Tut":
                    cSBtn.gameObject.SetActive(true);
                    oRBtn.gameObject.SetActive(false);
                    cCBtn.SetActive(false);
                    gBtn.SetActive(false);
                    fBtn.SetActive(true);
                    mBtn.SetActive(false);
                    nBtn.SetActive(false);
                    break;
                case "Mon":                   
                    cSBtn.gameObject.SetActive(true);
                    oRBtn.gameObject.SetActive(false);
                    if (!ceceGone) { cCBtn.SetActive(true); }
                    if (!gnomiesGone) { gBtn.SetActive(false); }
                    if (!fredGone) { fBtn.SetActive(false); }
                    mBtn.SetActive(false);
                    if(!nicoGone) { nBtn.SetActive(true); }
                    break;
                case "Tue":
                    cSBtn.gameObject.SetActive(true);
                    oRBtn.gameObject.SetActive(false);
                    if (!ceceGone) { cCBtn.SetActive(false); }
                    if (!gnomiesGone) { gBtn.SetActive(true); }
                    if (!fredGone) { fBtn.SetActive(true); }
                    mBtn.SetActive(false);
                    if (!nicoGone) { nBtn.SetActive(false); }
                    break;
                case "Wed":
                    cSBtn.gameObject.SetActive(true);
                    oRBtn.gameObject.SetActive(false);
                    if (!ceceGone) { cCBtn.SetActive(false); }
                    if (!gnomiesGone) { gBtn.SetActive(false); }
                    if (!fredGone) { fBtn.SetActive(false); }
                    mBtn.SetActive(true);
                    if (!nicoGone) { nBtn.SetActive(false); }
                    break;
                case "Thu":
                    cSBtn.gameObject.SetActive(true);
                    oRBtn.gameObject.SetActive(false);
                    if (!ceceGone) { cCBtn.SetActive(true); }
                    if (!gnomiesGone) { gBtn.SetActive(true); }
                    if (!fredGone) { fBtn.SetActive(false); }
                    mBtn.SetActive(false);
                    if (!nicoGone) { nBtn.SetActive(false); }
                    break;
                case "Fri":
                    cSBtn.gameObject.SetActive(false);
                    oRBtn.gameObject.SetActive(false);
                    if (!ceceGone) { cCBtn.SetActive(false); }
                    if (!gnomiesGone) { gBtn.SetActive(false); }
                    if (!fredGone) { fBtn.SetActive(true); }
                    mBtn.SetActive(true);
                    if (!nicoGone) { nBtn.SetActive(false); }
                    break;
                case "Sat":
                    cSBtn.gameObject.SetActive(false);
                    oRBtn.gameObject.SetActive(false);
                    if (!ceceGone) { cCBtn.SetActive(true); }
                    if (!gnomiesGone) { gBtn.SetActive(false); }
                    if (!fredGone) { fBtn.SetActive(false); }
                    mBtn.SetActive(true);
                    if (!nicoGone) { nBtn.SetActive(true); }
                    break;
                case "Fin":
                    {
                        cSBtn.gameObject.SetActive(false);
                        oRBtn.gameObject.SetActive(true);
                        cCBtn.SetActive(false);
                        gBtn.SetActive(false);
                        fBtn.SetActive(false);
                        mBtn.SetActive(false);
                        nBtn.SetActive(false);
                        break;
                    }
                default:
                    Debug.Log("not a valid day set in playerprefs");
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
            if (currentChoices.Count > 0)
            {
                choicesDisplayed = true;
                autoMode = false;
                autoText.SetActive(false);
                canContinueToNextLine = true;
            }
            else
            {
                canContinueToNextLine = true;
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
        public void SaveGame()
        {
            dV.SaveVariables();
        }


        public void OnApplicationQuit()
        {
            /*if(dV != null)
            {
                dV.SaveVariables();
            }*/
            
        }
    }
}
