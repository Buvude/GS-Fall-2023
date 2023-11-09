using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.MicroGame.BT
{
    public class Table : MonoBehaviour
    {
        public DirtSpots dirt;
        public GameObject silverwareNapkinCombo;
        public FullTable fT;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void onClick()
        {
            if (dirt.clean)
            {
                silverwareNapkinCombo.SetActive(true);
                fT.numberBussed++;
            }
        }
    }
}
