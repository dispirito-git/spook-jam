using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rune : MonoBehaviour
{
    public GameObject board;
    private static float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!board.activeSelf)
        {
            if  (t == 0)
            {
                t = Time.time + 1.5f;
            }
            if (Time.time > t)
            {
                transform.gameObject.SetActive(false);
            }
        }

    }
}
