using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Rune : MonoBehaviour
{
    public GameObject board;
    private static float t;
    public UnityEvent function;

    // Start is called before the first frame update
    void Start()
    {
        //transform.gameObject.SetActive(true); ;
    }

    // Update is called once per frame
    void Update()
    {
       // if (!board.activeSelf && transform.gameObject.activeSelf && transform.gameObject.layer>=3)
        if (!board.activeSelf && transform.gameObject.activeSelf && transform.GetComponent<SpriteRenderer>().sortingOrder >= 3)
        {
            //Debug.Log("Adios");
            if  (t == 0)
            {
                t = Time.time + 1.5f;
            }
            if (Time.time > t)
            {
                transform.gameObject.SetActive(false);
                function.Invoke();
                t = 0;
            }
        }

    }
}
