using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.BA
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject Lane1, Lane2, Lane3;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("trigger entered");
        }
    }
}
