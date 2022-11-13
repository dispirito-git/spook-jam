using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookUpdate : MonoBehaviour
{
    public GameObject book;
    //public GameObject rune;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (book.activeSelf && Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Book have");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                
                GameObject temp = hit.collider.gameObject;
                Debug.Log(temp.transform.name);
                if (temp.transform.name == transform.gameObject.name)
                {
                    transform.gameObject.SetActive(false);
                }
            }
        }
       
        
    }
}
