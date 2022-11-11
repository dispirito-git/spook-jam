using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Random = System.Random;

public class Note : MonoBehaviour
{
    public GameObject noteBox;
    GameObject noteBox1;
    public string text;
    public string text1;
    
    private Random rand = new Random();

    // Start is called before the first frame update
    void Start()
    {
        noteBox1 = noteBox.GetComponentsInChildren<Image>()[1].gameObject;
        noteBox.SetActive(false);
        //noteBox1.SetActive(false);
        //Following reformats the text input if needed to be on two lines
        int dex = text.IndexOf('~');
        if (dex!= -1)
        {
            text = text.Substring(0, dex) + "\n" + text.Substring(dex + 1);
        }
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
            if(text1.Length>1)
            {
                noteBox1.GetComponentInChildren<TextMeshProUGUI>().SetText(text1);
                noteBox.SetActive(!noteBox.activeSelf);
            }
            else
            {
                noteBox.SetActive(!noteBox.activeSelf);
                noteBox1.SetActive(!noteBox.activeSelf);
            }
            
            GameObject p = GameObject.FindGameObjectWithTag("Player");
            GetComponent<AudioSource>().pitch = ((float)(rand.NextDouble() * 0.4f) + 0.8f);
            p.GetComponent<AudioSource>().PlayOneShot(p.GetComponent<PlayerTeleport>().paper);
            Debug.Log("AAAAAA");
        }
    }
   
}
