using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension
{
    public class CharBtnParent : MonoBehaviour
    {
        public Image sR;
        public string[] sDictKey, dDictKey;
        public Sprite[] sDictValue;
        public TextAsset[] dDictValue;
        // Start is called before the first frame update
        void Start()
        {
            /* ORspriteDictionary = new Dictionary<string, Sprite>();
            if (sDictKey.Length != sDictValue.Length)
            {
                Debug.LogWarning("The length of moods is different then the list of sprites");
                return;
            }
            else
            {
                for(int i = 0; i < sDictKey.Length; i++)
                {
                    ORspriteDictionary.Add(sDictKey[i], sDictValue[i]);
                }
            }
            ORdialogueDictionary = new Dictionary<string, TextAsset>();
            if (dDictKey.Length != dDictValue.Length)
            {
                Debug.LogWarning("The length of dialogue is different then the list of dialogue assets");
                return;
            }
            else
            {
                for (int i = 0; i < dDictKey.Length; i++)
                {
                    ORdialogueDictionary.Add(dDictKey[i], dDictValue[i]);
                }
            }*/
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
