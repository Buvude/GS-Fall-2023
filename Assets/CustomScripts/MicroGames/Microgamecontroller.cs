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
        public BAManeger bAM;
        public List<BurgerIngredients.ingredientType> orderedIngredients;


        public GameObject tempMicroGameHolder;

        void Start()
        {

        }


        void Update()
        {

        }

        public void StartBAM(int level)
        {
            dM.ExitDialogueMode(false, 0,0);
            bAMContainer.SetActive(true);
            bAM.StartMicroGame(orderedIngredients, level);
        }
        public void StartBAM(GameObject bun, GameObject pickle, GameObject greens,GameObject patty, GameObject condiment, GameObject veggie,GameObject tbun)
        {
            dM.ExitDialogueMode(false, 0, 0);
            bAMContainer.SetActive(true);
            bAM.LevelUp(bun, pickle, greens, patty,condiment, veggie,tbun);
            bAM.StartMicroGame(orderedIngredients, 2);
        }

    }
}
