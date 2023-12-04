using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace InterDineMension.Manager
{
    public class tittleScreenManager : MonoBehaviour
    {
        public Button loadgame;
        public GameObject warning;
        // Start is called before the first frame update
        void Start()
        {
            if (!PlayerPrefs.HasKey("dayVar"))
            {
                loadgame.interactable = false;
            }
        }

        // Update is called once per frame
        void Update()
        {
    
        }

        public void NewGameStart()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetString("newGame", "true");
            PlayerPrefs.SetString("timeOfDay", "morning");
            SceneManager.LoadScene(1);
        }

        public void LoadGameStart()
        {
            if (PlayerPrefs.GetString("weekDay") != "Sun")
            {
                PlayerPrefs.SetString("newGame", "false");
                PlayerPrefs.SetString("timeOfDay", "morning");
                SceneManager.LoadScene(1);
            }
            else
            {
                PlayerPrefs.SetString("newGame", "false");
                PlayerPrefs.SetString("timeOfDay", "Apt");
                SceneManager.LoadScene(5);
            }
            
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        public void StartBtnWarning()
        {
            if (PlayerPrefs.HasKey("dayVar"))
            {
                warning.SetActive(true);
            }
            else
            {
                NewGameStart();
            }
        }
    }
}



