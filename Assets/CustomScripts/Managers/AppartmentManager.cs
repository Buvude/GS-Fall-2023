using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.Manager
{
    public class AppartmentManager : MonoBehaviour
    {
        public List<GameObject> appartmentUpgrades, charAptUp;
        public List<string> CharAptKeys;
        public Dictionary<string, GameObject> charAptUpDict;
        public TextAsset appartmentIntro, postTTMPractice, postBAMPractice;
        public dialogueManager dM;
        // Start is called before the first frame update
        private void Awake()
        {
            PlayerPrefs.SetString("timeOfDay", "Apt");
            
        }
        void Start()
        {
            
            if (CharAptKeys.Count != charAptUp.Count)
            {
                Debug.LogError("the number of keys are not = to the number of char apt upgrades");
            }
            for (int i = 0; i < CharAptKeys.Count; i++)
            {
                charAptUpDict.Add(CharAptKeys[i], charAptUp[i]);
            }
            for (int i = 0; i < PlayerPrefs.GetInt("aptUpgrade"); i++)
            {
                if (appartmentUpgrades[i] != null)
                {
                    appartmentUpgrades[i].SetActive(true);
                }
                else
                {
                    break;
                }
            }
            if (PlayerPrefs.GetInt("convo_numberORT")>0)
            {
                //realizing I could have written this in a seperate script, might have been better organized. oh well. this is just to set up the character upgrades to your apartment
                /*if (PlayerPrefs.GetInt("convo_numberCST") >= 3)
                {
                    if (PlayerPrefs.GetInt("chaosCST") >= 9)
                    {
                        //set chaos apt upgrade for active
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("affectionCST") >= 0)
                        {
                            //set good apt upgrade for active
                        }
                        else
                        {
                            //set bad apt upgrade active
                        }
                    }
                }
                if (PlayerPrefs.GetInt("convo_numberCCT") >= 4)
                {
                    if (PlayerPrefs.GetInt("chaosCCT") >= 3)
                    {
                        //set chaos apt upgrade for active
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("affectionCCT") >= 0)
                        {
                            //set good apt upgrade for active
                        }
                        else
                        {
                            //set bad apt upgrade active
                        }
                    }
                }
                if (PlayerPrefs.GetInt("convo_numberGT") >= 4)
                {
                    if (PlayerPrefs.GetInt("chaosGT") >= 3)
                    {
                        //set chaos apt upgrade for active
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("affectionGT") >= 0)
                        {
                            //set good apt upgrade for active
                        }
                        else
                        {
                            //set bad apt upgrade active
                        }
                    }
                }
                if (PlayerPrefs.GetInt("convo_numberFT") >= 4)
                {
                    if (PlayerPrefs.GetInt("chaosFT") >= 3)
                    {
                        //set chaos apt upgrade for active
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("affectionFT") >= 0)
                        {
                            //set good apt upgrade for active
                        }
                        else
                        {
                            //set bad apt upgrade active
                        }
                    }
                }
                if (PlayerPrefs.GetInt("convo_numberMT") >= 4)
                {
                    if (PlayerPrefs.GetInt("chaosMT") >= 3)
                    {
                        //set chaos apt upgrade for active
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("affectionMT") >= 0)
                        {
                            //set good apt upgrade for active
                        }
                        else
                        {
                            //set bad apt upgrade active
                        }
                    }
                }
                if (PlayerPrefs.GetInt("convo_numberNT") >= 4)
                {
                    if (PlayerPrefs.GetInt("chaosNT") >= 3)
                    {
                        //set chaos apt upgrade for active
                    }
                    else
                    {
                        if (PlayerPrefs.GetInt("affectionNT") >= 0)
                        {
                            //set good apt upgrade for active
                        }
                        else
                        {
                            //set bad apt upgrade active
                        }
                    }
                }*/
                //now I'm making it a seperate script for each
            }

        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void sleep()
        {

        }
    }
}
