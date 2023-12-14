using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.SceneManagement;

namespace InterDineMension.Manager
{
    public class GameplayManager : MonoBehaviour
    {
        internal bool paused;
        /*[SerializeField] public List<TextAsset> cheffSwattsConvos;
        [SerializeField] public List<TextAsset> FredConvos;*/
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
                dialogueManager.GetInstance().EnterDialogueMode(manager.IntroOryan);
            }*/
            if(Input.GetKeyDown(KeyCode.Escape)||Input.GetKeyDown(KeyCode.P))
            {
                if(manager != null)
                {
                    if (paused)
                    {
                        paused = false;
                        manager.pauseScreen.SetActive(false);
                    }
                    else
                    {
                        paused = true;
                        manager.pauseScreen.SetActive(true);
                    }
                }
                
            }
        }
        public void StartConvoCheffSwatts()
        {
            //check variables to see which conversation to start. 
            //manager.EnterDialogueMode(cheffSwattsConvos[0]);
            //filler for until we have implimented the variables

        }

        public void StartConvoFred()
        {
            //check variables to see which story to start
        }
        private void OnApplicationQuit()
        {
            if (manager.dV != null)
            {
                manager.dV.clearTempVars(manager.vH);
            }
            
        }
       
    }
}
