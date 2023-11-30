using InterDineMension.Appartment;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.Appartment
{
    public class AptUpUnlock : AptUpParent
    {
        public int unlockIndex;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(dM == null);
            if (!(PlayerPrefs.GetInt("aptUpgradeT") >= unlockIndex))//index starts at 0, will build as the days progress
            {
                self.gameObject.SetActive(false);
            }
            else//enables object in room
            {
                selfSprite.enabled = true;
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
