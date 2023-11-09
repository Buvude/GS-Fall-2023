using InterDineMension.MicroGame.TT;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace InterDineMension.MicroGame.TT
{
    public class Hands : MonoBehaviour
    {
        public TTManager manager;
        public BoxCollider2D upperbounds;
        public ThrownObjectScript currentObject;
        public reticalControl rc;
        public Transform objectParent;
        public List<GameObject> options;

        public bool animating=false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void releaseObject()
        {
            currentObject.ThrowObject();
        }

        public void pickupNewObject()
        {
            if(options.Count > 1)
            {
                int temp=Random.Range(0, options.Count);
                Instantiate(options[temp],objectParent);
            }
            else if(options.Count == 1)
            {
                Instantiate(options[0],objectParent);
            }
            else
            {
                Debug.LogWarning("No items in options");
            }
        }

        public void ReadyToThrow()
        {
            rc.canThrow = true;
        }
    }
}
