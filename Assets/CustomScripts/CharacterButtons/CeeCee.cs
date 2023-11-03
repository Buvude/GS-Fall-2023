using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.Character
{
    public class CeeCee : MonoBehaviour
    {
        public Image sR;
        public Dictionary<string, Sprite> spriteDictionary = new Dictionary<string, Sprite>();
        public string[] dictKeyCC;
        public Sprite[] dictValueCC;
        // Start is called before the first frame update
        void Awake()
        {
            if (dictKeyCC.Length != dictValueCC.Length)
            {
                Debug.LogWarning("The length of moods is different then the list of sprites");
                return;
            }
            else
            {
                for(int i = 0; i < dictKeyCC.Length; i++)
                {
                    spriteDictionary.Add(dictKeyCC[i], dictValueCC[i]);
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
