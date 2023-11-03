using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension
{
    public class BinMovment : MonoBehaviour
    {
        public float speed;
        public BoxCollider2D leftBoundary, rightBoundary;
        public enum direction { left, right };
        public direction mvmtDirection = direction.left;
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
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            switch (mvmtDirection)
            {
                case direction.left:
                    {
                        this.gameObject.transform.Translate(-transform.right * speed);
                        break;
                    }
                case direction.right:
                    {
                        this.gameObject.transform.Translate(transform.right * speed);
                        break;
                    }
            }
        }
    }
}
