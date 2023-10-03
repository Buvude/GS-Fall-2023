using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.MicroGame
{
    using InterDineMension.MicroGame.BA;
    using System;

    public class Microgamecontroller : MonoBehaviour
    {
        public Canvas canvas;

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
            bAMContainer.SetActive(true);
            bAM.StartMicroGame(orderedIngredients);
        }
    }
}
