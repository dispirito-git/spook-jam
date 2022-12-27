using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
public class EntryBark : MonoBehaviour
{
    public GameObject BarkText;
    public string text;
    private Bark bark;
    public GameObject stop;
    private static bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        //BarkText.GetComponent<TextMeshProUGUI>().SetText(text);
        BarkText.SetActive(true);
        bark = new Bark(text, new InterObj(transform.gameObject), stop);
        bark.setActive(true);
        bark.setT(Time.time + 1.5f);
        BarkText.GetComponent<TextMeshProUGUI>().SetText(bark.getText());


    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time <= bark.getT())
        {
            BarkText.SetActive(true);
        }

        if (Time.time >= bark.getT() && BarkText.activeSelf && bark.getActive())
        {
            //Debug.Log("c:" + Time.time + " e:" + bark.getT());
            //Debug.Log("AAAHAHLSA "+bark.getText());
            BarkText.SetActive(false);
            bark.setActive(false);
            bark.getStopStatus();
        }
    }
}