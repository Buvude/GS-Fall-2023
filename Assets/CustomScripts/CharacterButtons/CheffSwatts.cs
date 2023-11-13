using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.Character
{
    public class CheffSwatts : MonoBehaviour
    {
        //public TextAsset CS1, CS2;
        public Image sR;
        public Dictionary<string, Sprite> spriteDictionary;
        public Dictionary<string, TextAsset> dialogueDictionary;
        public string[] sDictKeyCS, dDictKeyCS;
        public Sprite[] sDictValueCS;
        public TextAsset[] dDictValueCS;
        // Start is called before the first frame update
       
        /// <summary>
        /// sets up the dictionaries
        /// </summary>
        void Awake()
        {
            spriteDictionary = new Dictionary<string, Sprite>();
            if (sDictKeyCS.Length != sDictValueCS.Length)
            {
                Debug.LogWarning("The length of moods is different then the list of sprites");
                return;
            }
            else
            {
                for(int i = 0; i < sDictKeyCS.Length; i++)
                {
                    spriteDictionary.Add(sDictKeyCS[i], sDictValueCS[i]);
                }
            }
            dialogueDictionary = new Dictionary<string, TextAsset>();
            if (dDictKeyCS.Length != dDictValueCS.Length)
            {
                Debug.LogWarning("The length of dialogue is different then the list of dialogue assets");
                return;
            }
            else
            {
                for (int i = 0; i < dDictKeyCS.Length; i++)
                {
                    dialogueDictionary.Add(dDictKeyCS[i], dDictValueCS[i]);
                }
            }
            //Debug.Log(spriteDictionary.Count);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
