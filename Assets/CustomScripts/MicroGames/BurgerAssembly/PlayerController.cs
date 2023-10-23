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
        public SpriteRenderer bottomBunRend, picklesRend, lettuceRend, pattyRend, condimentRend, finalBonusRend, topBunRend;
        public Sprite 
            classicBottomBun, lettuceWrapBottom, noBottomBun,//top bun types
            pickles, relish, noPickles, //pickle type 
            wholeLeafLettuce, choppedLettuce, noLettuce,//Lettuce type
            beefPatty, veganPatty, unspeakableHorror,//patty type
            ketchup, mustard, both,//condiment choice
            tomatoe, choppedOnions, none,//final bonus choice
            classicTopBun, lettuceWrapTop, noTopBun;//top bun choice
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
            if (Input.GetKey(KeyCode.RightArrow))
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
            else if (Input.GetKey(KeyCode.LeftArrow))
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
                    bottomBunRend.sprite = classicBottomBun;
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
                    bottomBunRend.sprite = lettuceWrapBottom;
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
                    bottomBunRend.sprite = noBottomBun;
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
                case BurgerIngredients.ingredientType.pickles:
                    picklesRend.sprite = pickles;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.pickles)
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
                    picklesRend.sprite = relish;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.relish)
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
                    picklesRend.sprite = noPickles;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.noPickles)
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
                    lettuceRend.sprite = wholeLeafLettuce;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.wholeLeafLettuce)
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
                    lettuceRend.sprite = choppedLettuce;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.choppedLettuce)
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
                    lettuceRend.sprite = noLettuce;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.noLettuce)
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
                case BurgerIngredients.ingredientType.beefPatty:
                    pattyRend.sprite = beefPatty;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.beefPatty)
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
                    pattyRend.sprite = veganPatty;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.veganPatty)
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
                    pattyRend.sprite = unspeakableHorror;
                    ingredientTypes.Add(type);
                    aS.clip = cosmic;
                    aS.Play();
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.ketchup:
                    condimentRend.sprite = ketchup;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.ketchup)
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
                    condimentRend.sprite = mustard;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.mustard)
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
                    condimentRend.sprite = both;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.both)
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
                    finalBonusRend.sprite = tomatoe;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.tomatoe)
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
                    finalBonusRend.sprite = choppedOnions;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.choppedOnions)
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
                    finalBonusRend.sprite = none;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.none)
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
                case BurgerIngredients.ingredientType.classicTopBun:
                    topBunRend.sprite = classicTopBun;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.classicTopBun)
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
                    topBunRend.sprite = lettuceWrapBottom;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.lettuceWrapTop)
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
                    topBunRend.sprite = noTopBun;
                    ingredientTypes.Add(type);
                    if (BAManeger.orderedIngredients[0] == BurgerIngredients.ingredientType.noTopBun)
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
                default:
                    break;
            }
        }
    }
}
