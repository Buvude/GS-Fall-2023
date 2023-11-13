using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using InterDineMension.Manager;
using JetBrains.Annotations;
using System;

namespace InterDineMension.MicroGame.TT
{
    public class TTManager : MonoBehaviour
    {
        public GameObject recycling, compost, recyclingBag, compostBag;
        public VariableHolder vH;
        public float scorepause;
        public int score, goal;
        public AudioClip correct, wrong;
        public AudioSource aS;
        public int timeLimit;
        public TextMeshProUGUI timerText, instructions, scoretxt;
        public bool timerHasStarted, timerHasEnded;
        public List<FallingObjectScript> fallenObjects;
        private int fOSize;
        public reticalControl rc;
        public BoxCollider2D topCollider;
        public bool gameEnded=false;
        public const int SCORE1=3, SCORE2=6, SCORE3=9;

        // Start is called before the first frame update
        void Start()
        {
            vH=GameObject.FindGameObjectWithTag("variableHolder").GetComponent<VariableHolder>();


            scoretxt.text = $"<b>{score}/{goal}</b> pieces of trash sorted correctly";
            fOSize = 0;
            timerText.text = $"{timeLimit} seconds";
            initializeTTMiniGame();
        }

        public void initializeTTMiniGame()
        {
            Debug.Log(vH.currentStory.variablesState["TTMLevel"]);
            switch (vH.currentStory.variablesState["TTMLevel"].ToString())
            {
                case "1":
                    goal=SCORE1 ; break;
                case "2":
                    goal = SCORE2;
                    recycling.SetActive(true);
                    rc.player.options.Add(recyclingBag);
                    break;
                case "3":
                    goal = SCORE3;
                    recycling.SetActive(true);
                    compost.SetActive(true);
                    rc.player.options.Add(recyclingBag);
                    rc.player.options.Add(compostBag);
                    break;
                default:
                    break;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if ( fallenObjects.Count> fOSize && !fallenObjects[fOSize].canScore)
            {
                fOSize += 1;
                fallenObjects[fOSize-1].canScore = true;
                if (fallenObjects[fOSize-1].worthPoint)
                {
                    aS.clip = correct; aS.Play();
                    score++;
                    scoretxt.text = $"<b>{score}/{goal}</b> pieces of trash sorted correctly";
                }
                else
                {
                    aS.clip = wrong; aS.Play();
                }

                if(score>=goal)
                {
                    score = 0;
                    gameEnded = true;
                    StopCoroutine(timer() );
                    StartCoroutine(tallyUp() );
                    topCollider.enabled = false;
                }
            }
            if(!timerHasStarted&&fallenObjects.Count>=1 && !gameEnded) 
            {
                scoretxt.text = "";
                timerHasStarted = true;
                StartCoroutine(timer() );
            }

        }

        

        IEnumerator tallyUp()
        {
            score=0; gameEnded = true;
            rc.player.GetComponent<Animator>().SetTrigger("End");
            timerHasEnded = true;
            rc.speed = 0f;
            instructions.text=$"Score: {score}/{goal}";

            foreach(var f in fallenObjects)
            {
                if (f.worthPoint)
                {
                    f.transform.parent = null;
                    f.transform.localScale.Set(1, 1, 1);
                    PlusPoint(f);
                }
                else
                {
                    f.transform.parent = null;
                    f.transform.localScale.Set(1, 1, 1);
                    noPoint(f);
                }
                yield return new WaitForSeconds(scorepause);
            }
            if (score >= goal)
            {
                vH.wonMini = true;
            }
            else
            {
                vH.wonMini= false;
            }
            
        }
        public void PlusPoint(FallingObjectScript f)
        {
            score++;
            f.gameObject.GetComponent<Rigidbody2D>().gravityScale = -10f;
            aS.clip= correct;aS.Play();
            instructions.text = $"Score: {score}/{goal}";
        }

        public void noPoint(FallingObjectScript f)
        {
            f.gameObject.layer = 7;
            aS.clip = wrong; aS.Play();
            instructions.text = $"Score: {score}/{goal}";
        }
        IEnumerator timer()
        {
            for (int i = timeLimit; i>=0; i--)
            {
                timerText.text = $"{i} seconds";
                yield return new WaitForSeconds(1);
            }
            topCollider.enabled = false;   
            StartCoroutine(tallyUp());
            gameEnded = true;
            StopCoroutine(timer());
        }
    }
}
