using InterDineMension.MicroGame.TT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension
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
                canScore = false;
                location=BinLandedIn.trash;
                if (type == objectType.trash)
                {
                    worthPoint = true;
                }
            }
            else if(collision.gameObject.layer == 11&&canScore)
            {
                canScore=false;
                location=BinLandedIn.none;
                worthPoint=false;
            }

        }
    }
}
