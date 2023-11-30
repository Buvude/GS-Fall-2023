using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.Character
{
    public class Nico : CharBtnParent
    {
        public Dictionary<string, Sprite> NspriteDictionary;
        public Dictionary<string, TextAsset> NdialogueDictionary;

        // Start is called before the first frame update
        void Awake()
        {
            NspriteDictionary = new Dictionary<string, Sprite>();
            if (sDictKey.Length != sDictValue.Length)
            {
                Debug.LogWarning("The length of moods is different then the list of sprites");
                return;
            }
            else
            {
                for (int i = 0; i < sDictKey.Length; i++)
                {
                    NspriteDictionary.Add(sDictKey[i], sDictValue[i]);
                }
            }
            NdialogueDictionary = new Dictionary<string, TextAsset>();
            if (dDictKey.Length != dDictValue.Length)
            {
                Debug.LogWarning("The length of dialogue is different then the list of dialogue assets");
                return;
            }
            else
            {
                for (int i = 0; i < dDictKey.Length; i++)
                {
                    NdialogueDictionary.Add(dDictKey[i], dDictValue[i]);
                }
            }

        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
