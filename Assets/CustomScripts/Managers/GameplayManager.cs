using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

namespace InterDineMension.Manager
{
    public class GameplayManager : MonoBehaviour
    {
        public dialogueManager manager;
        // Start is called before the first frame update
        void Start()
        {
            dialogueManager.GetInstance().StartFirstConvo();
        }

        // Update is called once per frame
        void Update()
        {
            /*if (!dialogueManager.GetInstance().dialoguePlaying)
            {
                dialogueManager.GetInstance().EnterDialogueMode(manager.inkJSON);
            }*/
        }
    }
}
