using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.Character
{
    public class Fred : CharBtnParent
    {
        public Dictionary<string, Sprite> FspriteDictionary;
        public Dictionary<string, TextAsset> FdialogueDictionary;

        // Start is called before the first frame update
        void Awake()
        {
            FspriteDictionary = new Dictionary<string, Sprite>();
            if (sDictKey.Length != sDictValue.Length)
            {
                Debug.LogWarning("The length of moods is different then the list of sprites");
                return;
            }
            else
            {
                for (int i = 0; i < sDictKey.Length; i++)
                {
                    FspriteDictionary.Add(sDictKey[i], sDictValue[i]);
                }
            }
            FdialogueDictionary = new Dictionary<string, TextAsset>();
            if (dDictKey.Length != dDictValue.Length)
            {
                Debug.LogWarning("The length of dialogue is different then the list of dialogue assets");
                return;
            }
            else
            {
                for (int i = 0; i < dDictKey.Length; i++)
                {
                    FdialogueDictionary.Add(dDictKey[i], dDictValue[i]);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
