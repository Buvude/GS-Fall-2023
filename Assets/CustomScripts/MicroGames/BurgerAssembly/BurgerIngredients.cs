using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.BA
{
    public class BurgerIngredients : MonoBehaviour
    {

        public enum lanePos
        {
            lane1, lane2, lane3
        };
        public enum ingredientType
        {
            classicBottomBun, lettuceWrapBottom, noBottomBun,//top bun types
            pickles, relish, noPickles, //pickle type 
            wholeLeafLettuce, choppedLettuce, noLettuce,//Lettuce type
            beefPatty, veganPatty, unspeakableHorror,//patty type
            ketchup, mustard, both,//condiment choice
            tomatoe, choppedOnions, none,//final bonus choice
            classicTopBun, lettuceWrapTop, noTopBun//top bun choice
        };
        public ingredientType ing;
        public lanePos currentpos;
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
            switch (currentpos)
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
                default:
                    Debug.Log("default Triggered");
                    break;
            }
            this.gameObject.SetActive(false);
        }
    }
}
