using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;

namespace InterDineMension.Manager
{
    public class tittleScreenManager : MonoBehaviour
    {
        public Image CGFade;
        public Sprite black;
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
            StartCoroutine(EndSceneFadeOut());
        }

        public void LoadGameStart()
        {
            if (PlayerPrefs.GetString("weekDay") != "Sun")
            {
                PlayerPrefs.SetString("newGame", "false");
                PlayerPrefs.SetString("timeOfDay", "morning");
                StartCoroutine(EndSceneFadeOut());

            }
            else
            {
                PlayerPrefs.SetString("newGame", "false");
                PlayerPrefs.SetString("timeOfDay", "Apt");
                StartCoroutine(EndSceneFadeOut());

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
        public IEnumerator EndSceneFadeOut()
        {
            CGFade.gameObject.SetActive(true);
            CGFade.sprite = black;
            for (float a = 0; a <= 1.1; a += .01f)
            {
                yield return new WaitForSeconds(.01f);
                CGFade.color = new UnityEngine.Color(1, 1, 1, a);
            }
            SceneManager.LoadScene(1);
        }
    }
}



