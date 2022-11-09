using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickBark : MonoBehaviour
{
    public GameObject BarkText;
    public string text;
    public int thres = 40;
    // Start is called before the first frame update
    void Start()
    {
        BarkText.SetActive(false);
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
            BarkText.GetComponent<TextMeshProUGUI>().SetText(text);
            BarkText.SetActive(!BarkText.activeSelf);
            Debug.Log("Hehehe");
        }
    }
}
