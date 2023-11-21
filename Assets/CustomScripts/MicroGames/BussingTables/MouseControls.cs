using InterDineMension.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.MicroGame.BT
{
    /// <summary>
    /// this script will function as a manager for the whole minigame as well as controlling the mouse. 
    /// </summary>
    public class MouseControls : MonoBehaviour
    {
        public GameObject rag;
        public List<GameObject> tableListLvl1, tableListLvl2, tableListLvl3;
        public int index;
        public int level;
        public VariableHolder vH;
        // Start is called before the first frame update
        void Start()
        {
            vH=GameObject.FindGameObjectWithTag("variableHolder").GetComponent<VariableHolder>();
            switch (vH.currentStory.variablesState["TBMLevel"].ToString())
            {
                case "1":
                    Instantiate(tableListLvl1[0],this.gameObject.transform);
                    index = 1;
                    level = 1;
                    break;
                default:
                    Debug.LogWarning("something went wrong");
                    Debug.Log(vH.currentStory.variablesState["TBMLevel"].ToString());
                    break;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(1))
            {
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hitData = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, 0);
                rag.transform.position = new Vector2(worldPosition.x, worldPosition.y);
            }

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hitData = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, 0);
                if (hitData.collider.gameObject.layer == 15)
                {
                    hitData.collider.gameObject.GetComponent<Table>().onClick();
                }
            }
            
            
        }
        public void spawnNextTable(FullTable ft)
        {
            if (level == 1 && index != tableListLvl1.Count)
            {
                Destroy(ft.gameObject);
                Instantiate(tableListLvl1[index], this.gameObject.transform);
                index++;
            }
        }
    }
}
