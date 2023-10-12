using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.MicroGame
{
    using InterDineMension.MicroGame.BA;
    using System;
    using InterDineMension.Manager;
    public class Microgamecontroller : MonoBehaviour
    {
        public Canvas canvas;
        public GameObject dialogueContainer;
        public dialogueManager dM;
        public GameObject bAMContainer;
        public BAManeger bAM = new BAManeger();
        public List<BurgerIngredients.ingredientType> orderedIngredients = new List<BurgerIngredients.ingredientType>();


        public GameObject tempMicroGameHolder;

        void Start()
        {

        }


        void Update()
        {

        }

        public void StartBAM()
        {
            dM.ExitDialogueMode();
            bAMContainer.SetActive(true);
            bAM.StartMicroGame(orderedIngredients);
        }
    }
}
