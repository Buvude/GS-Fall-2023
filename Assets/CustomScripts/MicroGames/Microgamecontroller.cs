using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.SceneManagement;

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
        public Story currentStory;


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

        public void loadTTM()
        {
            SceneManager.LoadScene("TTMinigame");
        }

        public void StartBAM(GameObject bBun2, GameObject pickles2, GameObject greens2, GameObject patty2, GameObject condiment2, GameObject veggie2, GameObject bun2, GameObject bBun3, GameObject pickles3, GameObject greens3, GameObject patty3, GameObject condiment3, GameObject veggie3, GameObject bun3)
        {
            dM.ExitDialogueMode(false, 0, 0);
            bAMContainer.SetActive(true);
            bAM.LevelUp(bBun2, pickles2, greens2, patty2, condiment2, veggie2, bun2, bBun3, pickles3, greens3, patty3, condiment3, veggie3, bun3);
            bAM.StartMicroGame(orderedIngredients, 3);
        }
    }
}
