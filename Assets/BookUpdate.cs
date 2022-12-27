using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookUpdate : MonoBehaviour
{
    public GameObject book;
    private InterObj me;
    private int stat;
    //public GameObject rune;
    // Start is called before the first frame update
    void Start()
    {
        stat = PlayerPrefs.GetInt("BCaseStat");
        me = new InterObj(transform.gameObject);
        if (stat == 1)
        {
            transform.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (book.activeSelf && me.isClicked())
        {
            transform.gameObject.SetActive(false);
            PlayerPrefs.SetInt("BCaseStat", 1);
            //Debug.Log("Book have");
            /* Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
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
             }*/
        }
       
        
    }
}
