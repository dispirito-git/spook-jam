using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Note : MonoBehaviour, IPointerDownHandler
{
    public GameObject noteBox;
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        noteBox.SetActive(false);
    }
    Vector3 worldPosition;
    int thres = 40;
    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //Debug.Log((transform.position - worldPosition).magnitude);
        if (Input.GetMouseButtonDown(0) && Mathf.Abs((transform.position-worldPosition).magnitude)< thres)
        {
            noteBox.GetComponentInChildren<TextMeshProUGUI>().SetText(text);
            noteBox.SetActive(!noteBox.activeSelf);
            Debug.Log("AAAAAA");
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
   
}
