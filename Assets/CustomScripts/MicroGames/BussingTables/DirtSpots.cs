using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.MicroGame.BT
{
    public class DirtSpots : MonoBehaviour
    {
        public bool clean = false;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (this.GetComponent<SpriteRenderer>().color.a == 0)
            {
                clean = true;
                this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.gameObject.layer==13)
            {
                Color tmp;
                tmp = this.GetComponent<SpriteRenderer>().color;
                tmp.a -= .25f;
                this.GetComponent<SpriteRenderer>().color = tmp;
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.collider.gameObject.layer == 13)
            {
                Color tmp;
                tmp = this.GetComponent<SpriteRenderer>().color;
                tmp.a -= .25f;
                this.GetComponent<SpriteRenderer>().color = tmp;
            }
        }
    }
}
