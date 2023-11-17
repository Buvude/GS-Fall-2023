using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

namespace InterDineMension.Manager
{
    
    /// <summary>
    /// this is to both store what image will be shown, and show it. 
    /// </summary>
    public class dialogueSpriteManager : MonoBehaviour
    {
        public Image imagePopUp;
        public List<Image> orderImages=new List<Image>();
        public Sprite
            classicBottomBun, lettuceWrapBottom, noBottomBun,bBunOfTheDeep,pretzelBBun, sourdoughBBun,//top bun types
            pickles, relish, noPickles,peppers,allSeeingEyes,plain, //pickle type 
            wholeLeafLettuce, choppedLettuce, noLettuce,biblicallyAcurateGreens, aLeaf, purple,//Lettuce type
            beefPatty, mushroom, mysteryMeat,chicken,cheeseburger,//patty type
            ketchup, mustard, both,neither, slime, mayo,//condiment choice
            tomatoe, choppedOnions, none,mushrooms,onionRings,theThing,//final bonus choice
            classicTopBun, lettuceWrapTop, noTopBun,tBunOfTheDeep, pretzelTBun, sourdoughTBun;//top bun choice
       /* public enum ingredientType
        {
            classicBottomBun, lettuceWrapBottom, noBottomBun,//top bun types
            chips, relish, noPickles, //pickle type 
            wholeLeafLettuce, choppedLettuce, noLettuce,//Lettuce type
            beefPatty, mushroomPatty, mysteryMeat,//patty type
            ketchup, mustard, both,//condiment choice
            tomatoe, choppedOnions, none,//final bonus choice
            classicTopBun, lettuceWrapTop, noTopBun//top bun choice
        };
        public ingredientType ing;*/
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void DisplayImage(Sprite popUp, int phase)
        {
            if(popUp != null)
            {
                imagePopUp.gameObject.SetActive(true);
                orderImages[phase-1].gameObject.SetActive(true);
                imagePopUp.sprite = popUp;
                orderImages[phase-1].sprite = popUp;
            }

            else
            {
                imagePopUp.gameObject.SetActive(false);
                orderImages[phase-1].gameObject.SetActive(false);
            }

            
        }
    }
}
