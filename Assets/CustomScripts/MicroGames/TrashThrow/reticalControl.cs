using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace InterDineMension.MicroGame.TT
{
    public class reticalControl : MonoBehaviour
    {
        public GameObject hitMarker;
        public TTManager manager;
        public GameObject fallingTrash, fallingRecycling, fallingCompost;
        public Vector3 dropSpot;
        public Hands player;
        public float speed;
        private float speedHolder;
        public BoxCollider2D leftBoundary, rightBoundary;
        public enum direction { left, right };
        public direction mvmtDirection=direction.left;
        public bool canThrow = true;
        // Start is called before the first frame update
        void Start()
        {
            manager.rc = this;
            speedHolder = speed;
        }

        // Update is called once per frame
        void Update()
        {
            switch (mvmtDirection)
            {
                case direction.left:
                    {
                        this.gameObject.transform.Translate( -transform.right*speed);
                        break;
                    }
                case direction.right:
                    {
                        this.gameObject.transform.Translate(transform.right*speed);
                        break;
                    }
            }

            
            if (canThrow&&!manager.timerHasEnded&&(Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Z)||Input.GetKeyDown(KeyCode.Space)))
            {
                if(hitMarker.transform.parent != null) 
                {
                    hitMarker.transform.parent = null;
                }

                canThrow = false;
                dropSpot = transform.position;
                hitMarker.transform.position = dropSpot;
                player.GetComponent<Animator>().SetTrigger("Throw");
                player.animating = true;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider == leftBoundary)
            {
                mvmtDirection = direction.right;
            }
            else if (collision.collider == rightBoundary)
            {
                mvmtDirection = direction.left;
            }
            else { return; }
        }

        public void SpawnFallingObject(Vector3 drop,ThrownObjectScript.objectType oT)
        {
            switch (oT)
            {
                case ThrownObjectScript.objectType.trash:
                    GameObject tempt= Instantiate(fallingTrash, drop, Quaternion.Euler(1f, 1f, 1f));
                    tempt.GetComponent<FallingObjectScript>().manager = manager;
                    break;
                case ThrownObjectScript.objectType.recycling:
                    GameObject tempr = Instantiate(fallingRecycling, drop, Quaternion.Euler(1f, 1f, 1f));
                    tempr.GetComponent<FallingObjectScript>().manager = manager;
                    break;
                case ThrownObjectScript.objectType.compost:
                    GameObject tempc = Instantiate(fallingCompost, drop, Quaternion.Euler(1f, 1f, 1f));
                    tempc.GetComponent<FallingObjectScript>().manager = manager;
                    break;
                default:
                    break;
            }
        }
    }
}
