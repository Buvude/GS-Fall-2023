using InterDineMension.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.Appartment
{
    public class AptUpParent : MonoBehaviour
    {
        public TextAsset description;
        public Image selfSprite;
        public GameObject self;
        internal AppartmentManager aM;
        internal dialogueManager dM;
        // Start is called before the first frame update
        void Start()
        {
            aM=GameObject.FindGameObjectWithTag("eventSystem").GetComponent<AppartmentManager>();
            dM = aM.dM;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void PlayDescription()
        {
            dM.EnterDialogueMode(description);
        }
    }
}
