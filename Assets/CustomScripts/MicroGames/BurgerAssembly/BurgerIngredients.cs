using InterDineMension.MicroGame.BA;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.MicroGame.BA
{
    public class BurgerIngredients : MonoBehaviour
    {
        public enum lanePos
        {
            lane1, lane2, lane3, lane4, lane5
        };
        public enum ingredientType
        {
            classicBottomBun, lettuceWrapBottom, noBottomBun,bottomBunOfTheDeep, sourdoughBottom, pretzelBottom, //bottom bun types
            pickles, relish, noPickles,peppers, wholePickle, allSeeingEyes, //pickle type 
            wholeLeafLettuce, choppedLettuce, noLettuce,biblicallyAccurateGreens, aLeaf, purple,//Lettuce type
            beefPatty, mushroomPatty, unspeakableHorror,chicken, withCheese,//patty type
            ketchup, mustard, both,neither, mayo, slime,//condiment choice
            tomatoe, choppedOnions, none,mushrooms, onionRings, theHand,//final bonus choice
            classicTopBun, lettuceWrapTop, noTopBun,topBunOfTheDeep, sourdoughTop, pretzelTop //top bun choice
        };
        public ingredientType ing;
        public lanePos currentposIngredients;
        public PlayerController player;
        
        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void EndOfTheLine()
        {
            switch (currentposIngredients)
            {
                case lanePos.lane1:
                    if (player.currentpos == PlayerController.lanePos.lane1)
                    {
                        player.CollectIngredient(ing);
                    }
                    break;
                case lanePos.lane2:
                    if (player.currentpos == PlayerController.lanePos.lane2)
                    {
                        player.CollectIngredient(ing);
                    }
                    break;
                case lanePos.lane3:
                    if (player.currentpos == PlayerController.lanePos.lane3)
                    {
                        player.CollectIngredient(ing);
                    }
                    break;
                case lanePos.lane4:
                    {
                        if (player.currentpos == PlayerController.lanePos.lane4)
                        {
                            player.CollectIngredient(ing);
                        }
                        break;
                    }
                case lanePos.lane5:
                    {
                        if (player.currentpos == PlayerController.lanePos.lane5)
                        {
                            player.CollectIngredient(ing);
                        }
                        break;
                    }
                default:
                    Debug.Log("default Triggered");
                    break;
            }
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }
    }

    
}
