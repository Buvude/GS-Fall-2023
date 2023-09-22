using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace InterDineMension.MicroGame.BA
{
    public class BAManeger : MonoBehaviour
    {

        public GameObject lane1, lane2, lane3;//lanes will increase with higher difficulty
        /// <summary>
        /// an enum to determine the state of the microgame
        /// </summary>
        public enum phase//this will determine what will spawn
        {
            sBun, bonus1, bonus2, Patty, bonus3, bonus4, eBun
        };
        public phase bAState=phase.sBun;
        /// <summary>
        /// lists of objects that can spawn in the microgame
        /// </summary>
        public List<GameObject> sBunOptions = new List<GameObject>();
        public List<GameObject> bonus1Options=new List<GameObject>();
        public List<GameObject> bonus2Options = new List<GameObject>();
        public List<GameObject> PattyOptions = new List<GameObject>();
        public List<GameObject> bonus3Options = new List<GameObject>();
        public List<GameObject> bonus4Options = new List<GameObject>();
        public List<GameObject> eBunOptionsOptions = new List<GameObject>();
        public List<GameObject> toSpawn=new List<GameObject>();
        // Start is called before the first frame update

        public void StartTheNextPhase()
        {
            switch (bAState)
            {
                case phase.sBun:
                    shuffleList(sBunOptions);
                    Instantiate(toSpawn[0], lane1.transform);
                    Instantiate(toSpawn[1], lane2.transform);
                    Instantiate(toSpawn[2], lane3.transform);
                    toSpawn.Clear();
                    foreach (GameObject obj in toSpawn)
                    {
                        Debug.Log(obj.name);
                    }
                    break;
                case phase.bonus1:
                    break;
                case phase.bonus2:
                    break;
                case phase.Patty:
                    break;
                case phase.bonus3:
                    break;
                case phase.bonus4:
                    break;
                case phase.eBun:
                    break;
                default:
                    break;
            }
        }
        //code help by wideeyenow_unity at https://discussions.unity.com/t/how-can-i-shuffle-a-list/75012/7

        public void shuffleList(List<GameObject> toShuffle)
        {
            List<GameObject> temp = new List<GameObject>();
            temp.AddRange(toShuffle);
            for (int i = 0; i < toShuffle.Count; i++)
            {
                int index=Random.Range(0, temp.Count - 1);//using unity system.random
                toSpawn.Add(temp[index]);
                temp.RemoveAt(index);
            }
            foreach (GameObject item in toSpawn)
            {
                Debug.Log(item.name);
            }
        }
    }
}
