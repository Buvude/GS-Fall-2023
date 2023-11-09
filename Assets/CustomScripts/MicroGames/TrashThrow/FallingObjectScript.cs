using InterDineMension.MicroGame.TT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.MicroGame.TT
{
    public class FallingObjectScript : MonoBehaviour
    {
        public TTManager manager;
        public bool canScore = true, worthPoint=false;
        public enum objectType { trash, recycling, compost };
        public objectType type;
        public enum BinLandedIn { trash, recycling, compost, none };
        public BinLandedIn location;
        // Start is called before the first frame update
        void Start()
        {
            manager.fallenObjects.Add(this);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == 8&&canScore)
            {
                //this.gameObject.transform.parent = collision.gameObject.GetComponentInChildren<Transform>();
                canScore = false;
                location=BinLandedIn.trash;
                if (type == objectType.trash)
                {
                    worthPoint = true;
                }
            }
            else if (collision.gameObject.layer == 9 && canScore)
            {
                //this.gameObject.transform.parent = collision.gameObject.GetComponentInChildren<GameObject>().transform;
                canScore = false;
                location = BinLandedIn.recycling;
                if (type == objectType.recycling)
                {
                    worthPoint = true;
                }
            }
            else if (collision.gameObject.layer == 10 && canScore)
            {
                //this.gameObject.transform.parent = collision.gameObject.GetComponentInChildren<GameObject>().transform;
                canScore = false;
                location = BinLandedIn.compost;
                if (type == objectType.compost)
                {
                    worthPoint = true;
                }
            }
            else if(collision.gameObject.layer == 12&&canScore)
            {
                canScore=false;
                location=BinLandedIn.none;
                worthPoint=false;
            }

        }
    }
}
