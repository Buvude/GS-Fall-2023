using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InterDineMension.Character
{
    public class O_Ryan : MonoBehaviour
    {
        public Image sR;
        public Dictionary<string, Sprite> spriteDictionary = new Dictionary<string, Sprite>();
        public string[] dictKeyoR;
        public Sprite[] dictValueoR;
        // Start is called before the first frame update
        void Awake()
        {
            if (dictKeyoR.Length != dictValueoR.Length)
            {
                Debug.LogWarning("The length of moods is different then the list of sprites");
                return;
            }
            else
            {
                for(int i = 0; i < dictKeyoR.Length; i++)
                {
                    spriteDictionary.Add(dictKeyoR[i], dictValueoR[i]);
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
