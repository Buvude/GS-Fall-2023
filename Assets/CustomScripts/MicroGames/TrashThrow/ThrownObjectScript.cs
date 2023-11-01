using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.MicroGame.TT
{
    public class ThrownObjectScript : MonoBehaviour
    {
        public TTManager manager;
        public Vector3 dropPosition = Vector3.zero;
        public BoxCollider2D bc;
        public Rigidbody2D rb;
        public enum objectType { trash, recycling, compost};
        public objectType type;
        public reticalControl rc;
        public Hands parenthand;
        // Start is called before the first frame update
        void Start()
        {
            parenthand = gameObject.GetComponentInParent<Hands>();
            rc = parenthand.rc;
            bc = parenthand.upperbounds;
            gameObject.GetComponentInParent<Hands>().currentObject = this;
            rb.gravityScale = 0f;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("got here");
            if (collision.collider == bc)
            {
                Debug.Log("Level 2");
                rc.SpawnFallingObject(dropPosition, type);
                Destroy(this.gameObject);
            }
        }
        public void ThrowObject()
        {
            this.transform.parent = null;
            dropPosition = rc.dropSpot;
            dropPosition.y = 5.55f;
            rb.gravityScale = -15f;
        }
    }
}
