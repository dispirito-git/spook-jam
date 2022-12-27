using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickBark : MonoBehaviour
{
    public GameObject BarkText;
    public string text;
    private Bark bark;
    public GameObject stop;
    private static bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        bark = new Bark(text, new InterObj(transform.gameObject),stop);
        //Debug.Log("Stop is "+stop);
        //Debug.Log(bark.getStopStatus());
        /*if (stop == null)
        {
            bark = new Bark(text, new InterObj(transform.gameObject));
        }
        else
        {
            bark = new Bark(text, new InterObj(transform.gameObject),stop);
        }*/
        //t = 0f;
        BarkText.SetActive(false);
    }
    Vector3 worldPosition;

    // Update is called once per frame
    void Update()
    {
        if (bark.StartClicked() && !bark.getDone())
        {
            bark.setActive(true);
            //Debug.Log(Time.time);
            bark.setT(Time.time + 2.5f);
            //Debug.Log("c:" + Time.time + "e:" + bark.getT());
            BarkText.GetComponent<TextMeshProUGUI>().SetText(bark.getText());
            BarkText.SetActive(!BarkText.activeSelf);
            //Debug.Log("Hehehe" + (Time.time >= bark.getT()));
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
