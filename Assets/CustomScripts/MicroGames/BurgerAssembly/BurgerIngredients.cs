using InterDineMension.MicroGame.BA;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.MicroGame.BA
{
    public class BurgerIngredients : MonoBehaviour
    {
        public const float DELAY = .25f;
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
            StartCoroutine(delay());
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void CheckInBB()
        {
            if (player.BAManeger.bAState == BAManeger.phase.bottomBun)
            {
                switch (currentposIngredients)
                {
                    case lanePos.lane1:
                        if (player.currentpos == PlayerController.lanePos.lane1)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane2:
                        if (player.currentpos == PlayerController.lanePos.lane2)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane3:
                        if (player.currentpos == PlayerController.lanePos.lane3)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane4:
                        if (player.currentpos == PlayerController.lanePos.lane4)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane5:
                        if (player.currentpos == PlayerController.lanePos.lane5)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    default:
                        Debug.Log("default Triggered");
                        break;
                }
            }

        }
        public void CheckInPi()
        {
            if (player.BAManeger.bAState == BAManeger.phase.pickle)
            {
                switch (currentposIngredients)
                {
                    case lanePos.lane1:
                        if (player.currentpos == PlayerController.lanePos.lane1)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane2:
                        if (player.currentpos == PlayerController.lanePos.lane2)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane3:
                        if (player.currentpos == PlayerController.lanePos.lane3)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane4:
                        if (player.currentpos == PlayerController.lanePos.lane4)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane5:
                        if (player.currentpos == PlayerController.lanePos.lane5)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    default:
                        Debug.Log("default Triggered");
                        break;
                }
            }

        }
        public void CheckInGr()
        {
            if (player.BAManeger.bAState == BAManeger.phase.lettuce)
            {
                switch (currentposIngredients)
                {
                    case lanePos.lane1:
                        if (player.currentpos == PlayerController.lanePos.lane1)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane2:
                        if (player.currentpos == PlayerController.lanePos.lane2)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane3:
                        if (player.currentpos == PlayerController.lanePos.lane3)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane4:
                        if (player.currentpos == PlayerController.lanePos.lane4)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane5:
                        if (player.currentpos == PlayerController.lanePos.lane5)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    default:
                        Debug.Log("default Triggered");
                        break;
                }
            }

        }
        public void CheckInPa()
        {
            if (player.BAManeger.bAState == BAManeger.phase.Patty)
            {
                switch (currentposIngredients)
                {
                    case lanePos.lane1:
                        if (player.currentpos == PlayerController.lanePos.lane1)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane2:
                        if (player.currentpos == PlayerController.lanePos.lane2)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane3:
                        if (player.currentpos == PlayerController.lanePos.lane3)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane4:
                        if (player.currentpos == PlayerController.lanePos.lane4)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane5:
                        if (player.currentpos == PlayerController.lanePos.lane5)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    default:
                        Debug.Log("default Triggered");
                        break;
                }
            }

        }
        public void CheckInCo()
        {
            if (player.BAManeger.bAState == BAManeger.phase.condiment)
            {
                switch (currentposIngredients)
                {
                    case lanePos.lane1:
                        if (player.currentpos == PlayerController.lanePos.lane1)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane2:
                        if (player.currentpos == PlayerController.lanePos.lane2)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane3:
                        if (player.currentpos == PlayerController.lanePos.lane3)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane4:
                        if (player.currentpos == PlayerController.lanePos.lane4)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane5:
                        if (player.currentpos == PlayerController.lanePos.lane5)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    default:
                        Debug.Log("default Triggered");
                        break;
                }
            }

        }
        public void CheckInVe()
        {
            if (player.BAManeger.bAState == BAManeger.phase.veggie)
            {
                switch (currentposIngredients)
                {
                    case lanePos.lane1:
                        if (player.currentpos == PlayerController.lanePos.lane1)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane2:
                        if (player.currentpos == PlayerController.lanePos.lane2)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane3:
                        if (player.currentpos == PlayerController.lanePos.lane3)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane4:
                        if (player.currentpos == PlayerController.lanePos.lane4)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane5:
                        if (player.currentpos == PlayerController.lanePos.lane5)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    default:
                        Debug.Log("default Triggered");
                        break;
                }
            }

        }
        public void CheckInTB()
        {
            if (player.BAManeger.bAState == BAManeger.phase.topBun)
            {
                switch (currentposIngredients)
                {
                    case lanePos.lane1:
                        if (player.currentpos == PlayerController.lanePos.lane1)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane2:
                        if (player.currentpos == PlayerController.lanePos.lane2)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane3:
                        if (player.currentpos == PlayerController.lanePos.lane3)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane4:
                        if (player.currentpos == PlayerController.lanePos.lane4)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    case lanePos.lane5:
                        if (player.currentpos == PlayerController.lanePos.lane5)
                        {
                            player.CollectIngredient(ing);
                            this.gameObject.GetComponent<Image>().enabled = false;
                        }
                        break;
                    default:
                        Debug.Log("default Triggered");
                        break;
                }
            }

        }
        public void EndOfTheLine()
        {
          
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("test collision");
        }

        IEnumerator delay()
        {
            yield return new WaitForSeconds(DELAY);
            this.GetComponent<Animator>().SetTrigger("Drop");
        }
    }

    
}
