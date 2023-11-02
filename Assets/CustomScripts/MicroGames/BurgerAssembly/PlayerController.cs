using InterDineMension.MicroGame.BA;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.MicroGame.BA
{

    public class PlayerController : MonoBehaviour
    {
        public float speed;
        public Slider playerMovment;
        public const float  lane4=16, lane1=39, lane2=63, lane3=82;
        public AudioSource aS;
        public AudioClip correct, wrong, cosmic;
        public BAManeger BAManeger;
        public Image bottomBunRend, picklesRend, lettuceRend, pattyRend, condimentRend, finalBonusRend, topBunRend;
        public Sprite 
            classicBottomBun, lettuceWrapBottom, noBottomBun,bottomBunOfTheDeep,//top bun types
            pickles, relish, noPickles, peppers, //pickle type 
            wholeLeafLettuce, choppedLettuce, noLettuce, biblicallyAccurateGreens,//Lettuce type
            beefPatty, veganPatty, unspeakableHorror,Chicken,//patty type
            ketchup, mustard, both,//condiment choice
            tomatoe, choppedOnions, none,mushrooms,//final bonus choice
            classicTopBun, lettuceWrapTop, noTopBun,topBunOfTheDeep;//top bun choice
        public GameObject Lane1, Lane2, Lane3;
        public List<BurgerIngredients.ingredientType> ingredientTypes = new List<BurgerIngredients.ingredientType>();
        public enum lanePos
        {
            lane1, lane2, lane3, lane4, lane5
        };

        public lanePos currentpos;
        // Start is called before the first frame update
        void Start()
        {
            currentpos = lanePos.lane2;
        }

        // Update is called once per frame
        void Update()
        {
            switch (playerMovment.value)//naming system is confusing, sorry about that if anyone else is reading this
            {
                case < lane4:
                    {
                        currentpos = lanePos.lane5;
                        break;
                    }
                case < lane1:
                    {
                        currentpos=lanePos.lane1;
                        break;
                    }
                case < lane2:
                    {
                        currentpos=lanePos.lane2;
                        break;
                    }
                case < lane3:
                    {
                        currentpos = lanePos.lane3;
                        break;
                    }
                
                case > lane3:
                    {
                        currentpos = lanePos.lane4;
                        break;
                    }

                default:
                    break;
            }
            if(playerMovment.value>playerMovment.maxValue) { playerMovment.value = playerMovment.maxValue; }
            if (playerMovment.value < playerMovment.minValue) { playerMovment.value = playerMovment.minValue; }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) 
            {
                /*switch (currentpos)
                {
                    case lanePos.lane1:
                        this.gameObject.transform.position = Lane2.transform.position;
                        currentpos = lanePos.lane2;
                        break;
                    case lanePos.lane2:
                        this.gameObject.transform.position = Lane3.transform.position;
                        currentpos = lanePos.lane3;
                        break;
                    case lanePos.lane3:
                        break;
                    default:
                        break;
                }*/
                playerMovment.value += speed;
            }
            else if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A) )
            {
               /* switch (currentpos)
                {
                    case lanePos.lane1:
                        break;
                    case lanePos.lane2:
                        this.gameObject.transform.position = Lane1.transform.position;
                        currentpos = lanePos.lane1;
                        break;
                    case lanePos.lane3:
                        this.gameObject.transform.position = Lane2.transform.position;
                        currentpos = lanePos.lane2;
                        break;
                    default:
                        break;
                }*/
               playerMovment.value -= speed;
            }
        }
        /// <summary>
        /// This is the collection method, it's long and annoying to write lmao, but it should work
        /// 
        /// the ingredientTypes list is used to store what orderedIngredients you've scored
        /// 
        /// the top bun cases will have a function to end the microgame and pass through the final score
        /// </summary>
        /// <param name="type"></param> (the lane the ingredient is in)
        public void CollectIngredient(BurgerIngredients.ingredientType type)
        {
            switch (type)
            {
                case BurgerIngredients.ingredientType.classicBottomBun:
                    //bottomBunRend.sprite = classicBottomBun;
                    FindLowestNullRenderer().sprite = classicBottomBun;
                    FindLowestNullRenderer().enabled = true;

                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.classicBottomBun)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.lettuceWrapBottom:
                    FindLowestNullRenderer().sprite = lettuceWrapBottom;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.lettuceWrapBottom)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.noBottomBun:
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.noBottomBun)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.bottomBunOfTheDeep:
                    FindLowestNullRenderer().sprite = bottomBunOfTheDeep;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    aS.clip = cosmic;
                    aS.Play();
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.pickles:
                    FindLowestNullRenderer().sprite = pickles;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[1] == BurgerIngredients.ingredientType.pickles)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.relish:
                    FindLowestNullRenderer().sprite = relish;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[1] == BurgerIngredients.ingredientType.relish)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.noPickles:
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[1] == BurgerIngredients.ingredientType.noPickles)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.peppers:
                    FindLowestNullRenderer().sprite = peppers;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[1] == BurgerIngredients.ingredientType.peppers)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.wholeLeafLettuce:
                    FindLowestNullRenderer().sprite = wholeLeafLettuce;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[2] == BurgerIngredients.ingredientType.wholeLeafLettuce)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.choppedLettuce:
                    FindLowestNullRenderer().sprite = choppedLettuce;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[2] == BurgerIngredients.ingredientType.choppedLettuce)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.noLettuce:
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[2] == BurgerIngredients.ingredientType.noLettuce)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.biblicallyAccurateGreens:
                    FindLowestNullRenderer().sprite = biblicallyAccurateGreens;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    aS.clip = cosmic;
                    aS.Play();
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.beefPatty:
                    FindLowestNullRenderer().sprite = beefPatty;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[3] == BurgerIngredients.ingredientType.beefPatty)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.veganPatty:
                    FindLowestNullRenderer().sprite = veganPatty;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[3] == BurgerIngredients.ingredientType.veganPatty)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.unspeakableHorror:
                    FindLowestNullRenderer().sprite = unspeakableHorror;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    aS.clip = cosmic;
                    aS.Play();
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.chicken:
                    FindLowestNullRenderer().sprite = Chicken;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[3] == BurgerIngredients.ingredientType.chicken)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.ketchup:
                    FindLowestNullRenderer().sprite = ketchup;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[4] == BurgerIngredients.ingredientType.ketchup)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.mustard:
                    FindLowestNullRenderer().sprite = mustard;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[4] == BurgerIngredients.ingredientType.mustard)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.both:
                    FindLowestNullRenderer().sprite = both;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[4] == BurgerIngredients.ingredientType.both)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.neither:
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[4] == BurgerIngredients.ingredientType.neither)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.tomatoe:
                    FindLowestNullRenderer().sprite = tomatoe;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[5] == BurgerIngredients.ingredientType.tomatoe)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.choppedOnions:
                    FindLowestNullRenderer().sprite = choppedOnions;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[5] == BurgerIngredients.ingredientType.choppedOnions)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.none:
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[5] == BurgerIngredients.ingredientType.none)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.mushrooms:
                    FindLowestNullRenderer().sprite = mushrooms;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[5] == BurgerIngredients.ingredientType.mushrooms)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.FinalTally(ingredientTypes);
                    break;
                case BurgerIngredients.ingredientType.classicTopBun:
                    FindLowestNullRenderer().sprite = classicTopBun;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[6] == BurgerIngredients.ingredientType.classicTopBun)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.FinalTally(ingredientTypes);
                    break;
                case BurgerIngredients.ingredientType.lettuceWrapTop:
                    FindLowestNullRenderer().sprite = lettuceWrapTop;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[6] == BurgerIngredients.ingredientType.lettuceWrapTop)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.FinalTally(ingredientTypes);
                    break;
                case BurgerIngredients.ingredientType.noTopBun:
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[6] == BurgerIngredients.ingredientType.noTopBun)
                    {
                        aS.clip = correct;
                        aS.Play();
                    }
                    else
                    {
                        aS.clip = wrong;
                        aS.Play();
                    }
                    BAManeger.FinalTally(ingredientTypes);
                    break;
                case BurgerIngredients.ingredientType.topBunOfTheDeep:
                    FindLowestNullRenderer().sprite = topBunOfTheDeep;
                    FindLowestNullRenderer().enabled = true;
                    ingredientTypes.Add(type);
                    aS.clip = cosmic;
                    aS.Play();
                    BAManeger.StartTheNextPhase();
                    break;
                default:
                    break;
            }
        }

        public void resetMiniGameSprites()
        {
            bottomBunRend.enabled = false;
            picklesRend.enabled = false;
            lettuceRend.enabled = false;
            pattyRend.enabled = false;
            condimentRend.enabled = false;
            finalBonusRend.enabled = false;
            topBunRend.enabled = false;
        }
        public Image FindLowestNullRenderer()
        {
            if(!bottomBunRend.IsActive()) { return bottomBunRend; }
            else if (!picklesRend.IsActive()) { return picklesRend; }
            else if (!lettuceRend.IsActive()) { return lettuceRend; }
            else if (!pattyRend.IsActive()) { return pattyRend; }
            else if (!condimentRend.IsActive()) { return condimentRend; }
            else if (finalBonusRend.IsActive()) { return finalBonusRend; }
            else { return topBunRend; }
        }
    }
}
