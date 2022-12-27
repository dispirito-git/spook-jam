using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRune : MonoBehaviour
{
    public GameObject rune;
    public int thres;
    // Start is called before the first frame update
    void Start()
    {

    }
    Vector3 worldPosition;

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //Debug.Log((transform.position - worldPosition).magnitude);
        if (Input.GetMouseButtonDown(0) && Mathf.Abs((transform.position - worldPosition).magnitude) < thres)
        {
            rune.SetActive(true);
        }
    }
}
