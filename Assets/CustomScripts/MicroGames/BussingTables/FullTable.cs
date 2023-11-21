using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.MicroGame.BT
{
    public class FullTable : MonoBehaviour
    {
        public List<Table> tableSections;
        public int numberBussed, numberOfSections;
        public Animator animator;
        public bool animationcalled = false;
        public MouseControls mc;
        // Start is called before the first frame update
        void Start()
        {
            numberOfSections = 0;
            foreach (Table table in tableSections)
            {
                numberOfSections++;
                table.fT = this;
            }
            mc=GetComponentInParent<MouseControls>();

        }

        // Update is called once per frame
        void Update()
        {
            if(numberBussed==numberOfSections&&!animationcalled)
            {
                animationcalled = true;
                animator.SetTrigger("exit");
            }
        }

        public void onExit()
        {
            mc.spawnNextTable(this);
        }
    }
}
