using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.Manager
{

    /// <summary>
    /// this is to both store what image will be shown, and show it. 
    /// </summary>
    public class dialogueSpriteManager : MonoBehaviour
    {
        public Image imagePopUp;
        public Sprite
            classicBottomBun, lettuceWrapBottom, noBottomBun,//top bun types
            pickles, relish, noPickles, //pickle type 
            wholeLeafLettuce, choppedLettuce, noLettuce,//Lettuce type
            beefPatty, veganPatty, unspeakableHorror,//patty type
            ketchup, mustard, both,//condiment choice
            tomatoe, choppedOnions, none,//final bonus choice
            classicTopBun, lettuceWrapTop, noTopBun;//top bun choice
       /* public enum ingredientType
        {
            classicBottomBun, lettuceWrapBottom, noBottomBun,//top bun types
            pickles, relish, noPickles, //pickle type 
            wholeLeafLettuce, choppedLettuce, noLettuce,//Lettuce type
            beefPatty, veganPatty, unspeakableHorror,//patty type
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

        public void DisplayImage(Sprite popUp)
        {
            if(popUp != null)
            {
                imagePopUp.gameObject.SetActive(true);
                imagePopUp.sprite = popUp;
            }
            else
            {
                imagePopUp.gameObject.SetActive(false);
            }
            
            
        }
    }
}
