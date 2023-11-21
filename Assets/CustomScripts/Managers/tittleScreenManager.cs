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
            SceneManager.LoadScene(1);
        }

        public void LoadGameStart()
        {
            SceneManager.LoadScene(1);
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



