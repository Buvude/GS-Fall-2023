using InterDineMension.MicroGame.BA;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace InterDineMension.MicroGame.BA
{

    public class PlayerController : MonoBehaviour
    {
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
            lane1, lane2, lane3
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
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                switch (currentpos)
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
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                switch (currentpos)
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
                }
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
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.lettuceWrapBottom:
                    bottomBunRend.sprite = lettuceWrapBottom;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.noBottomBun:
                    bottomBunRend.sprite = noBottomBun;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.pickles:
                    picklesRend.sprite = pickles;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.relish:
                    picklesRend.sprite = relish;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.noPickles:
                    picklesRend.sprite = noPickles;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.wholeLeafLettuce:
                    lettuceRend.sprite = wholeLeafLettuce;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.choppedLettuce:
                    lettuceRend.sprite = choppedLettuce;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.noLettuce:
                    lettuceRend.sprite = noLettuce;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.beefPatty:
                    pattyRend.sprite = beefPatty;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.veganPatty:
                    pattyRend.sprite = veganPatty;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.unspeakableHorror:
                    pattyRend.sprite = unspeakableHorror;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.ketchup:
                    condimentRend.sprite = ketchup;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.mustard:
                    condimentRend.sprite = mustard;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.both:
                    condimentRend.sprite = both;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.tomatoe:
                    finalBonusRend.sprite = tomatoe;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.choppedOnions:
                    finalBonusRend.sprite = choppedOnions;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.none:
                    finalBonusRend.sprite = none;
                    ingredientTypes.Add(type);
                    BAManeger.StartTheNextPhase();
                    break;
                case BurgerIngredients.ingredientType.classicTopBun:
                    topBunRend.sprite = classicTopBun;
                    ingredientTypes.Add(type);
                    BAManeger.FinalTally(ingredientTypes);
                    break;
                case BurgerIngredients.ingredientType.lettuceWrapTop:
                    topBunRend.sprite = lettuceWrapBottom;
                    ingredientTypes.Add(type);
                    break;
                case BurgerIngredients.ingredientType.noTopBun:
                    topBunRend.sprite = noTopBun;
                    ingredientTypes.Add(type);
                    break;
                default:
                    break;
            }
        }
    }
}
