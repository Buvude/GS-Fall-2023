using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.Character
{
    public class Gnomies : MonoBehaviour
    {
        public Image sR;
        public Dictionary<string, Sprite> spriteDictionary = new Dictionary<string, Sprite>();
        public string[] dictKeyG;
        public Sprite[] dictValueG;
        // Start is called before the first frame update
        void Awake()
        {
            if (dictKeyG.Length != dictValueG.Length)
            {
                Debug.LogWarning("The length of moods is different then the list of sprites");
                return;
            }
            else
            {
                for(int i = 0; i < dictKeyG.Length; i++)
                {
                    spriteDictionary.Add(dictKeyG[i], dictValueG[i]);
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
