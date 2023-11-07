using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterDineMension.MicroGame.BT
{
    public class MouseControls : MonoBehaviour
    {
        public GameObject rag;
        // Start is called before the first frame update
        void Start()
        {
        
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
    }
}
