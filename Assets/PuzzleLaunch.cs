using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleLaunch : MonoBehaviour

{
    public GameObject board;
    private int[] answers = new int[] { 0, 0, 180, 0, 0, 0, 90, 0, 0, 180, 0, 180, 0, 0, 0, 90 };
    private static int[] current = new int[] { 0, 0, 2, 0, 0, 0, 1, 0, 0, 2, 0, 2, 0, 0, 1, 1 };
    private int[] rots = new int[] { 0, 90, 180, 270 };
    // Start is called before the first frame update
    void Start()
    {
        for (int num = 0; num<16; num++)
        {
            //board.SetActive(false);
            GameObject temp = board.GetComponentsInChildren<SpriteRenderer>()[num+1].gameObject;
            temp.transform.Rotate(0,0,(rots[current[num]]));

        }
    }
    Vector3 worldPosition;
    int thres = 400;
    //Vector3 worldPositionA = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    // Update is called once per frame
    void Update()
    {
        //Vector3 worldPositionA = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) /*&& Mathf.Abs((transform.position - worldPositionA).magnitude) < thres*/)
        {
            board.SetActive(true);
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            Debug.Log("Meeeeee" + hit.collider);
            if (hit.collider != null && hit.collider.gameObject.layer.Equals(LayerMask.NameToLayer("Puzzle")))
            {
                GameObject temp = hit.collider.gameObject;
                Debug.Log(hit.collider.gameObject);
                temp.transform.Rotate(0, 0, temp.transform.rotation.z + 90);
                int c = 0;
                for (int num = 0; num < 16; num++)
                {
                    Debug.Log(num+":");
                    Debug.Log(board.GetComponentsInChildren<SpriteRenderer>()[num + 1].gameObject.transform.eulerAngles.z + "v"+ answers[num]);
                    //Debug.Log(rots[answers[num]]);
                    if (MathF.Abs(board.GetComponentsInChildren<SpriteRenderer>()[num + 1].gameObject.transform.eulerAngles.z - answers[num]) <49)
                    {
                        c++;
                    }
                    //Debug.Log(c);

                }
                Debug.Log(c);
                if (c == 16)
                {
                    board.SetActive(false);
                }


                //hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
        }
        /*Vector2 mousePos = Input.mousePosition;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //Debug.Log((transform.position - worldPosition).magnitude);
        if (Input.GetMouseButtonDown(0))
        {
            board.SetActive(true);
            Debug.Log(worldPosition);
        }*/


    }
}
