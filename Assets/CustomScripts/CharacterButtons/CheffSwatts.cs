using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.Character
{
    public class CheffSwatts : MonoBehaviour
    {
        public Dictionary<string,Sprite> spriteDictionary = new Dictionary<string,Sprite>();
        public string[] dictKeyCS;
        public Sprite[] dictValueCS;
        // Start is called before the first frame update
        void Start()
        {
            if (dictKeyCS.Length != dictValueCS.Length)
            {
                Debug.LogWarning("The length of moods is different then the list of sprites");
                return;
            }
            else
            {
                for(int i = 0; i < dictKeyCS.Length; i++)
                {
                    spriteDictionary.Add(dictKeyCS[i], dictValueCS[i]);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
