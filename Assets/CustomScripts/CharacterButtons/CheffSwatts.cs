using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.Character
{
    public class CheffSwatts : CharBtnParent
    {
        public Dictionary<string, Sprite> CsspriteDictionary;
        public Dictionary<string, TextAsset> CsdialogueDictionary;
        //public TextAsset CS1, CS2;

        // Start is called before the first frame update

        /// <summary>
        /// sets up the dictionaries
        /// </summary>
        void Awake()
        {
            CsspriteDictionary = new Dictionary<string, Sprite>();
            if (sDictKey.Length != sDictValue.Length)
            {
                Debug.LogWarning("The length of moods is different then the list of sprites");
                return;
            }
            else
            {
                for (int i = 0; i < sDictKey.Length; i++)
                {
                    CsspriteDictionary.Add(sDictKey[i], sDictValue[i]);
                }
            }
            CsdialogueDictionary = new Dictionary<string, TextAsset>();
            if (dDictKey.Length != dDictValue.Length)
            {
                Debug.LogWarning("The length of dialogue is different then the list of dialogue assets");
                return;
            }
            else
            {
                for (int i = 0; i < dDictKey.Length; i++)
                {
                    CsdialogueDictionary.Add(dDictKey[i], dDictValue[i]);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
