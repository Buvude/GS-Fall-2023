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
        public bool bussed;
        // Start is called before the first frame update
        void Start()
        {
            bussed = false;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void onClick()
        {
            if (dirt.clean&&!bussed)
            {
                bussed = true;
                silverwareNapkinCombo.SetActive(true);
                fT.numberBussed++;
            }
        }
    }
}
