using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

namespace InterDineMension.Manager
{
    public class GameplayManager : MonoBehaviour
    {
        [SerializeField] public List<TextAsset> cheffSwattsConvos;
        [SerializeField] public List<TextAsset> FredConvos;
        public dialogueManager manager;
        // Start is called before the first frame update
        void Start()
        {
            //dialogueManager.GetInstance().StartMorningConvo();
        }

        // Update is called once per frame
        void Update()
        {
            /*if (!dialogueManager.GetInstance().dialoguePlaying)
            {
                dialogueManager.GetInstance().EnterDialogueMode(manager.dayOneIntro);
            }*/
        }
        public void StartConvoCheffSwatts()
        {
            //check variables to see which conversation to start. 
            manager.EnterDialogueMode(cheffSwattsConvos[0]);
            //filler for until we have implimented the variables

        }

        public void StartConvoFred()
        {
            //check variables to see which story to start
        }
    }
}
