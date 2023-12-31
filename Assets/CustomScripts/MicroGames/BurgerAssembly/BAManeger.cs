using InterDineMension.MicroGame.BA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

namespace InterDineMension.MicroGame.BA
{
    using InterDineMension.Manager;
    using UnityEngine.SceneManagement;

    public class BAManeger : MonoBehaviour
    {
        public dialogueSpriteManager dsm;
        public bool reseted;
        public Animator final;
        public GameObject orderImages;
        public PlayerController pC;
        public Button startBtn;
        public BurgerIngredients blank1,blank2;
        public int level;
        public GameObject BAMObject;
        public GameplayManager gM;
        public dialogueManager dM;
        public Image finishedBurger;
        public Sprite GoodBurger, BadBurger, cosHorBurger;
        public static int finalScore = 0;
        public Microgamecontroller microgamecontroller;
        public VariableHolder vH;
        void Start()
        {
            
            microgamecontroller = GameObject.FindGameObjectWithTag("eventSystem").GetComponent<Microgamecontroller>();
            microgamecontroller.bAM = this;
            //StartMicroGame(microgamecontroller.orderedIngredients);
        }

        public TextMeshProUGUI leftOrder, rightOrder;
        public static List<BurgerIngredients.ingredientType> orderedIngredients=new List<BurgerIngredients.ingredientType> ();
        public GameObject lane1, lane2, lane3, lane4, lane5;//lanes will increase with higher difficulty
        /// <summary>
        /// an enum to determine the state of the microgame
        /// </summary>
        public enum phase//this will determine what will spawn
        {
            bottomBun, pickle, lettuce, Patty, condiment, veggie, topBun
        };
        public phase bAState;
        
        /// <summary>
        /// lists of objects that can spawn in the microgame
        /// </summary>
        public List<GameObject> bottomBunOptions;
        public List<GameObject> pickleOptions;
        public List<GameObject> lettuceOptions;
        public List<GameObject> PattyOptions;
        public List<GameObject> condimentsOptions;
        public List<GameObject> veggieOptions;
        public List<GameObject> topBunOptions;
        public List<GameObject> toSpawn;
        public AudioClip bam, afternoon;
        public void StartMicroGame(List<BurgerIngredients.ingredientType> ingredients, int levelSetter)
        {
            StartCoroutine(musicFadeIn(bam));
            dM.manager.imagePopUp.enabled = false;
            dM.manager.imagePopUpParent.gameObject.SetActive(false);
            for (int i = 0; i < ingredients.Count; i++)
            {
                orderedIngredients.Add(ingredients[i]);
            }
            string orderForSide = $"{orderedIngredients[0]}\n\n" +
                $"{orderedIngredients[1]}\n\n" +
                $"{orderedIngredients[2]}\n\n" +
                $"{orderedIngredients[3]}\n\n" +
                $"{orderedIngredients[4]}\n\n" +
                $"{ orderedIngredients[5]}\n\n" +
                $"{orderedIngredients[6]}";
            leftOrder.text = orderForSide;
            rightOrder.text = orderForSide;
            level = levelSetter;
        }
        public IEnumerator musicFadeIn(AudioClip temp)
        {
            AudioSource bgmAudioSource = dM.bgmAudioSource;
            float fadeInOutRate = dM.fadeInOutRate;
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
            while (bgmAudioSource.volume < 1)
            {
                yield return new WaitForSeconds(.1f);
                bgmAudioSource.volume += fadeInOutRate;
            }
        }
        public void LevelUp(GameObject bun, GameObject pickle, GameObject greens, GameObject patty, GameObject condiment, GameObject veggie, GameObject tbun)
        {

            bottomBunOptions.Add(bun);
            pickleOptions.Add(pickle);
            lettuceOptions.Add(greens);
            PattyOptions.Add(patty);
            condimentsOptions.Add(condiment);
            veggieOptions.Add(veggie);
            topBunOptions.Add(tbun);
        }
            

        public void LevelUp(GameObject bBun2, GameObject pickles2, GameObject greens2, GameObject patty2, GameObject condiment2, GameObject veggie2, GameObject bun2, GameObject bBun3, GameObject pickles3, GameObject greens3, GameObject patty3, GameObject condiment3, GameObject veggie3, GameObject bun3)
        {
            orderImages.SetActive(false);
            bottomBunOptions.Add(bBun2);
            pickleOptions.Add(pickles2);
            lettuceOptions.Add(greens2);
            PattyOptions.Add(patty2);
            condimentsOptions.Add(condiment2);
            veggieOptions.Add(veggie2);
            topBunOptions.Add(bun2);
            bottomBunOptions.Add(bBun3);
            pickleOptions.Add(pickles3);
            lettuceOptions.Add(greens3);
            PattyOptions.Add(patty3);
            condimentsOptions.Add(condiment3);
            veggieOptions.Add(veggie3);
            topBunOptions.Add(bun3);
        }
        // Start is called before the first frame update
        /// <summary>
        /// randomizes the placement of the items
        /// </summary>
        /// 
        //TODO make a 

        public void ResetMiniGame()
        {
            //reseted = true;
            vH.dM.gameObject.GetComponent<dialogueSpriteManager>().imagePopUp.enabled = false;
            pC.ingredientTypes.Clear();
            orderedIngredients.Clear();
            pC.resetMiniGameSprites();
            bAState = phase.bottomBun;
            finalScore = 0;
            finishedBurger.gameObject.SetActive(false);
            final.enabled = false;
            /* startBtn.gameObject.SetActive(true);*/
            pC.instructions.gameObject.SetActive(true);
            pC.playerMovment.value = 50;
            pC.playermovmentStarted = false;
            switch (level)
            {
                case 1:
                    break;
                case 2:
                    bottomBunOptions.Remove(bottomBunOptions[3]);
                    pickleOptions.Remove(pickleOptions[3]);
                    lettuceOptions.Remove(lettuceOptions[3]);
                    PattyOptions.Remove(PattyOptions[3]);
                    condimentsOptions.Remove(condimentsOptions[3]);
                    veggieOptions.Remove(veggieOptions[3]);
                    topBunOptions.Remove(topBunOptions[3]);
                    break;
                case 3:
                    bottomBunOptions.Remove(bottomBunOptions[4]);
                    pickleOptions.Remove(pickleOptions[4]);
                    lettuceOptions.Remove(lettuceOptions[4]);
                    PattyOptions.Remove(PattyOptions[4]);
                    condimentsOptions.Remove(condimentsOptions[4]);
                    veggieOptions.Remove(veggieOptions[4]);
                    topBunOptions.Remove(topBunOptions[4]);
                    bottomBunOptions.Remove(bottomBunOptions[3]);
                    pickleOptions.Remove(pickleOptions[3]);
                    lettuceOptions.Remove(lettuceOptions[3]);
                    PattyOptions.Remove(PattyOptions[3]);
                    condimentsOptions.Remove(condimentsOptions[3]);
                    veggieOptions.Remove(veggieOptions[3]);
                    topBunOptions.Remove(topBunOptions[3]); 
                    break;
                default:
                    break;
            }
            foreach(Image i in dsm.orderImages)
            {
                i.enabled = true;
            }

            dM.QuickSave();
        }
        public void StartTheNextPhase()
        {
            dsm.imagePopUp.enabled=false;
            switch (bAState)
            {
                case phase.bottomBun:
                    shuffleList(bottomBunOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    if (level == 1)
                    {
                        blank1.ing = BurgerIngredients.ingredientType.noBottomBun;
                        blank1.currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(blank1, lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noBottomBun;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    if (level == 2)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noBottomBun;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    else if (level == 3)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        toSpawn[4].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(toSpawn[4], lane5.transform);
                    }
                    toSpawn.Clear();
                    bAState = phase.pickle;
                    break;
                case phase.pickle:
                    shuffleList(pickleOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    if (level == 1)
                    {
                        blank1.ing = BurgerIngredients.ingredientType.noPickles;
                        blank1.currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(blank1, lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noPickles;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    if (level == 2)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noPickles;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    else if (level == 3)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        toSpawn[4].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(toSpawn[4], lane5.transform);
                    }
                    toSpawn.Clear();
                    dsm.orderImages[0].enabled = false;
                    bAState = phase.lettuce;
                    break;
                case phase.lettuce:
                    shuffleList(lettuceOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    if (level == 1)
                    {
                        blank1.ing = BurgerIngredients.ingredientType.noLettuce;
                        blank1.currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(blank1, lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noLettuce;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    if (level == 2)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noLettuce;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    else if (level == 3)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        toSpawn[4].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(toSpawn[4], lane5.transform);
                    }
                    toSpawn.Clear();
                    dsm.orderImages[1].enabled = false;
                    bAState = phase.Patty;
                    break;
                case phase.Patty:
                    shuffleList(PattyOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    if (level == 1)
                    {
                        blank1.ing = BurgerIngredients.ingredientType.noLettuce;
                        blank1.currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(blank1, lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noLettuce;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    if (level == 2)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noLettuce;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    else if (level == 3)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        toSpawn[4].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(toSpawn[4], lane5.transform);
                    }
                    toSpawn.Clear();
                    dsm.orderImages[2].enabled = false;
                    bAState = phase.condiment;
                    break;
                case phase.condiment:
                    shuffleList(condimentsOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    if (level == 1)
                    {
                        blank1.ing = BurgerIngredients.ingredientType.neither;
                        blank1.currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(blank1, lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.neither;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    if (level == 2)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.neither;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    else if (level == 3)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        toSpawn[4].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(toSpawn[4], lane5.transform);
                    }
                    toSpawn.Clear();
                    dsm.orderImages[3].enabled = false;
                    bAState = phase.veggie;
                    break;
                case phase.veggie:
                    shuffleList(veggieOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    if (level == 1)
                    {
                        blank1.ing = BurgerIngredients.ingredientType.none;
                        blank1.currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(blank1, lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.none;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    if (level == 2)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.none;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    else if (level == 3)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        toSpawn[4].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(toSpawn[4], lane5.transform);
                    }
                    toSpawn.Clear();
                    dsm.orderImages[4].enabled = false;
                    bAState = phase.topBun;
                    break;
                case phase.topBun:
                    dsm.orderImages[5].enabled = false;
                    shuffleList(topBunOptions);
                    toSpawn[0].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane1;
                    Instantiate(toSpawn[0], lane1.transform);
                    toSpawn[1].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane2;
                    Instantiate(toSpawn[1], lane2.transform);
                    toSpawn[2].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane3;
                    Instantiate(toSpawn[2], lane3.transform);
                    if (level == 1)
                    {
                        blank1.ing = BurgerIngredients.ingredientType.noTopBun;
                        blank1.currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(blank1, lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noTopBun;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    if (level == 2)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        blank2.ing = BurgerIngredients.ingredientType.noTopBun;
                        blank2.currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(blank2, lane5.transform);
                    }
                    else if (level == 3)
                    {
                        toSpawn[3].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane4;
                        Instantiate(toSpawn[3], lane4.transform);
                        toSpawn[4].GetComponent<BurgerIngredients>().currentposIngredients = BurgerIngredients.lanePos.lane5;
                        Instantiate(toSpawn[4], lane5.transform);
                    }
                    
                    toSpawn.Clear();

                    break;
                default:
                    break;
            }
        }
        //code help by wideeyenow_unity at https://discussions.unity.com/t/how-can-i-shuffle-a-list/75012/7

        public void shuffleList(List<GameObject> toShuffle)
        {
            List<GameObject> temp = new List<GameObject>();
            temp.AddRange(toShuffle);
            for (int i = 0; i < toShuffle.Count; i++)
            {
                int index=Random.Range(0, temp.Count);//using unity system.random
                toSpawn.Add(temp[index]);
                temp.RemoveAt(index);
            }
            
            
        }

        /// <summary>
        /// using a for loop instead of foreach so I can use the i variable to check the same position in both lists
        /// </summary>
        /// <param name="ingredientTypes"></param> used for keeping score to compare with orderedIngredients
        public void FinalTally(List<BurgerIngredients.ingredientType> ingredientTypes)
        {
            StartCoroutine(musicFadeIn(afternoon));
            dsm.orderImages[6].enabled = false;
            for (int i = 0;i < ingredientTypes.Count;)
            {
                if (ingredientTypes[i] == BurgerIngredients.ingredientType.unspeakableHorror || 
                    ingredientTypes[i]==BurgerIngredients.ingredientType.bottomBunOfTheDeep || 
                    ingredientTypes[i] == BurgerIngredients.ingredientType.topBunOfTheDeep  ||
                    ingredientTypes[i] == BurgerIngredients.ingredientType.biblicallyAccurateGreens||
                    ingredientTypes[i] == BurgerIngredients.ingredientType.slime||
                    ingredientTypes[i] == BurgerIngredients.ingredientType.allSeeingEyes||
                    ingredientTypes[i] == BurgerIngredients.ingredientType.theHand)
                {
                    finalScore -= 1;
                }
                if (ingredientTypes[i]== orderedIngredients[i])
                {
                    finalScore++;
                }
                else
                {
                    //finalScore--; maybe? not sure if we'll keep this yet
                }
                i++;
            }
            Debug.Log(finalScore);
            switch (finalScore)
            {
                case -7:
                    {
                        finishedBurger.sprite = cosHorBurger;
                        final.enabled = true;
                        break;
                    }
                case < 5:
                    {
                        finishedBurger.sprite = BadBurger;
                        final.enabled = true;
                        break;
                    }
                /*case <= 5:
                    {
                        finishedBurger.sprite = cosHorBurger;
                        final.enabled = true;
                        break;
                    }*/
                case >= 5:
                    {
                        finishedBurger.sprite = GoodBurger;
                        final.enabled = true;
                        break;
                    }
                //default: break;//unreachable, but still safe to have
            }
            StartCoroutine(BAMicroGameScore(finalScore));
            //will be used for passing the score through to another script as needed
        }

        private IEnumerator BAMicroGameScore(int finalScore)//used to determine where to go next
        {
            
            dM.charSpeakTo = dialogueManager.speakingTo.Swatts;
            /*Debug.Log(dM.vH.currentStory.variablesState["currentConvo"].ToString());
            Debug.Log(PlayerPrefs.GetString("currentConvo"));*/
            if (finalScore >= 5)
            { 
                yield return new WaitForSeconds(3);
                microgamecontroller.dialogueContainer.SetActive(true);
                BAMObject.SetActive(false);
                dM.gameObject.SetActive(true);
                if (PlayerPrefs.GetString("currentConvo") == "cSD0")
                {
                    ResetMiniGame();
                    dM.EnterDialogueMode(dM.cS.CsdialogueDictionary["cSMGPassIntro"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "cSD1")
                {
                    ResetMiniGame();
                    dM.EnterDialogueMode(dM.cS.CsdialogueDictionary["cSMGPass1"]); //only valid for day one
                }
                else if (PlayerPrefs.GetString("currentConvo") == "cSD2")
                {
                    ResetMiniGame();
                    dM.EnterDialogueMode(dM.cS.CsdialogueDictionary["cSMGPass2"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "GMG1")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "won");
                    dM.EnterDialogueMode(dM.G.GdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "GMG2")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "won");
                    dM.EnterDialogueMode(dM.G.GdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "practiceB")
                {
                    PlayerPrefs.SetString("winStatus", "Win");
                    SceneManager.LoadScene(5);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "FMG1")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "won");
                    dM.EnterDialogueMode(dM.F.FdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "FMG2")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "won");
                    dM.EnterDialogueMode(dM.F.FdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "MMG2")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "won");
                    dM.EnterDialogueMode(dM.M.MdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "finale")
                {
                    ResetMiniGame();
                    dM.setCharSpeakToOR();
                    dM.EnterDialogueMode(dM.oR.ORdialogueDictionary["finalBMPass"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "NMG3")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "won");
                    dM.EnterDialogueMode(dM.N.NdialogueDictionary["postMini"]);
                }
                else
                {
                    Debug.LogError($"not a valid currentConvo {PlayerPrefs.GetString("currentConvo")}");
                }

            }
            else if(finalScore > -7) 
            {

                yield return new WaitForSeconds(3);
                microgamecontroller.dialogueContainer.SetActive(true);
                BAMObject.SetActive(false);
                dM.gameObject.SetActive(true);
                if (PlayerPrefs.GetString("currentConvo") == "cSD0")
                {
                    ResetMiniGame();
                    dM.EnterDialogueMode(dM.cS.CsdialogueDictionary["cSMGFailIntro"]);
                }
                else if (PlayerPrefs.GetString("currentConvo")== "cSD1")
                {
                    ResetMiniGame();
                    dM.EnterDialogueMode(dM.cS.CsdialogueDictionary["cSMGFail1"]);//only valid for day one
                }
                else if (PlayerPrefs.GetString("currentConvo") == "cSD2")
                {
                    ResetMiniGame();
                    dM.EnterDialogueMode(dM.cS.CsdialogueDictionary["cSMGFail2"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "GMG1")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "loss");
                    dM.EnterDialogueMode(dM.G.GdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "GMG2")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "loss");
                    dM.EnterDialogueMode(dM.G.GdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "FMG1")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "loss");
                    dM.EnterDialogueMode(dM.F.FdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "FMG2")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "loss");
                    dM.EnterDialogueMode(dM.F.FdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "MMG2")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "loss");
                    dM.EnterDialogueMode(dM.M.MdialogueDictionary["postMini"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "practiceB")
                {
                    PlayerPrefs.SetString("winStatus", "Loss");
                    SceneManager.LoadScene(5);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "finale")
                {
                    ResetMiniGame();
                    dM.setCharSpeakToOR();
                    dM.EnterDialogueMode(dM.oR.ORdialogueDictionary["finalBMFail"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "NMG3")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "loss");
                    dM.EnterDialogueMode(dM.N.NdialogueDictionary["postMini"]);
                }
                else
                {
                    Debug.LogError("not a valid currentConvo");
                }

            }
            else if (finalScore == -7)
            {
                yield return new WaitForSeconds(3);
                microgamecontroller.dialogueContainer.SetActive(true);
                BAMObject.SetActive(false);
                dM.gameObject.SetActive(true);
                if (PlayerPrefs.GetString("currentConvo") == "cSD2")
                {
                    ResetMiniGame();
                    dM.EnterDialogueMode(dM.cS.CsdialogueDictionary["cSMGChaos"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "practiceB")
                {
                    PlayerPrefs.SetString("winStatus", "Chaos");
                    SceneManager.LoadScene(5);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "finale")
                {
                    ResetMiniGame();
                    dM.setCharSpeakToOR();
                    dM.EnterDialogueMode(dM.oR.ORdialogueDictionary["finalBMChaos"]);
                }
                else if (PlayerPrefs.GetString("currentConvo") == "NMG3")
                {
                    ResetMiniGame();
                    PlayerPrefs.SetString("winStatus", "chaos");
                    dM.EnterDialogueMode(dM.N.NdialogueDictionary["postMini"]);
                }
                else
                {
                    Debug.LogError("not a valid currentConvo");
                }
            }
            else
            {
                Debug.LogError("final score was below -7");
            }

            
        }
        

    }
}
