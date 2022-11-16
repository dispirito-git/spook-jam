using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && transform.position.x != -1946)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                GameObject temp = hit.collider.gameObject;
                Debug.Log("A?"+hit.collider.gameObject.name);
                if (temp.transform.name == transform.gameObject.name)
                {
                    Debug.Log("aYYOOO?");
                    transform.SetPositionAndRotation(new Vector3(-1946, 528, 0), new Quaternion(0,0,0,0));
                    //transform.position.x = -1946;
                    //transform.position.y = 528;


                }
            }
        }

    }
}
