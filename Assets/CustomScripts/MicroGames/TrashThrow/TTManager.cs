using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace InterDineMension.MicroGame.TT
{
    public class TTManager : MonoBehaviour
    {
        public float scorepause;
        public int score, goal;
        public AudioClip correct, wrong;
        public AudioSource aS;
        public int timeLimit;
        public TextMeshProUGUI timerText, instructions;
        public bool timerHasStarted, timerHasEnded;
        public List<FallingObjectScript> fallenObjects;
        public reticalControl rc;
        public BoxCollider2D topCollider;

        // Start is called before the first frame update
        void Start()
        {
            timerText.text = $"{timeLimit} seconds";
        }

        // Update is called once per frame
        void Update()
        {
            if(!timerHasStarted&&fallenObjects.Count>=1) 
            {
                timerHasStarted = true;
                StartCoroutine(timer() );
            }
        }

        IEnumerator tallyUp()
        {
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
            StopCoroutine(timer());
        }
    }
}
