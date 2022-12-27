using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class InterObj
    {
        private GameObject self;

        public InterObj(GameObject self)
        {
            this.self = self;
        }

        public bool isClicked()
        {
            if (self.activeSelf && Input.GetMouseButtonDown(0))
            {
                //Debug.Log("Book have");
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if (hit.collider != null)
                {

                    GameObject temp = hit.collider.gameObject;
                    Debug.Log(temp.transform.name);
                    if (temp.transform.name == self.transform.gameObject.name)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
