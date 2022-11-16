using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WallEyeControls : MonoBehaviour
{
    public GameObject cover;
    public GameObject BarkText;
    public string text;
    public int thres = 40;
    private static bool stop = false;
    private static float t;
    // Start is called before the first frame update
    void Start()
    {
        BarkText.SetActive(false);
    }
    Vector3 worldPosition;
    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            if (((int)Time.time) % 7 == 0)
            {
                cover.SetActive(true);
            }
            else
            {
                cover.SetActive(false);
            }
        }
        Vector2 mousePos = Input.mousePosition;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //Debug.Log((transform.position - worldPosition).magnitude);
        if (Input.GetMouseButtonDown(0) && Mathf.Abs((transform.position - worldPosition).magnitude) < thres && !stop)
        {
            Debug.Log(Time.time);
            t = Time.time + 1.5f;
            Debug.Log("c:" + Time.time + "e:" + t);
            BarkText.GetComponent<TextMeshProUGUI>().SetText(text);
            BarkText.SetActive(!BarkText.activeSelf);
            Debug.Log("Hehehe" + (Time.time >= t));
        }
        if (Time.time >= t && BarkText.activeSelf)
        {
            Debug.Log("c:" + Time.time + " e:" + t);
            Debug.Log("AAAHAHLSA");
            BarkText.SetActive(false);
            cover.SetActive(true);
            stop = true;
        }
    }
}