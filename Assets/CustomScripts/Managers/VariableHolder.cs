using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.Manager
{
    public class VariableHolder : MonoBehaviour
    {
        public TextAsset preventFarming;
        internal Story preventFarmingStory;
        public bool wonMini = false;
        public Story currentStory;
        public TextAsset curStor;
        internal dialogueManager dM;
        //these will track the stats for each character 
       /* public int 
            day,
            affectionCS, chaosCS, irritatedCS,//Cheff Swats trackers
            affectionN, chaosN, irritatedN,//Nico trackers
            affectionCC, chaosCC, irritatedCC,//CeCe trackers
            affectionG, chaosG, irritatedG,//Gnomies
            affectionM, chaosM, irritatedM,//Morgan trackers
            affectionF, chaosF, irritatedF,//Fred trackers
            finalEncounterTracker;//used to keep track of wins and losses in the final encounter with */
        //public bool characterStateNico;
        private static VariableHolder instance;
        public VariableHolder test;
        public bool testTest;

        // Start is called before the first frame update
        void Start()
        {
            test = instance;
            if (GameObject.FindGameObjectsWithTag("variableHolder").Length>=2)
            {
                Destroy(gameObject);
            }
            /*if (instance != null)
            {
                instance.DestroyCopy(this.gameObject); 
                //Destroy(this.gameObject);
                Debug.LogWarning($"Found more then one DialogueManager instance ");
            }*/
            preventFarmingStory = new Story(preventFarming.text);
            instance = this;
            test = instance;
            DontDestroyOnLoad(instance);

            currentStory = new Story(curStor.text);
        }

        // Update is called once per frame
        void Update()
        {
            if (PlayerPrefs.GetString("currentconvo") == "test" && testTest)
            {
                Debug.Break();
            }
        }
        public void DestroyCopy(GameObject clone)
        {
            Destroy(clone.gameObject);
        }
    }
}
