using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject debugTxt;
    float mouseX;
    float mouseY;
    float angle;
    float selfx;
    float selfy;
    float deltaAngle;
 
    // Start is called before the first frame update
    void Start()
    {
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y;
        selfx = transform.position.x;
        selfy = transform.position.y;
        angle = transform.rotation.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        //mouseX = .x;
        mouseX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        mouseY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        selfx = transform.position.x;
        selfy = transform.position.y;
        if ((transform.parent.lossyScale.x >= 0 && mouseX>selfx) || (transform.parent.lossyScale.x <= 0 && mouseX < selfx) )
        {
            //mouseX = Input.mousePosition.x;
            //mouseY = Input.mousePosition.y;
            //selfx = Camera.main.WorldToScreenPoint(transform.position).x;
            // selfy = Camera.main.WorldToScreenPoint(transform.position).y;
            selfx = transform.position.x;
            selfy = transform.position.y;
            float diffx = mouseX - selfx;
            float diffy = mouseY - selfy;
            float tempAngle = (Mathf.Rad2Deg * (Mathf.Atan(/*Mathf.Abs*/(diffy) / /*Mathf.Abs*/(diffx))));
            //debugTxt.GetComponent<TextMeshProUGUI>().SetText(/*diffx+","+diffy+"\n"+*/mouseX + "," + mouseY + "\n" + tempAngle);
            //deltaAngle = angle-tempAngle;
            //angle = tempAngle;
            //transform.Rotate(0, 0, deltaAngle);
            transform.rotation = Quaternion.Euler(0, 0, tempAngle);
        }
    }

}
