using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Assets.Scripts.Constants;

public class PuzzleLaunch : MonoBehaviour

{
    public GameObject board;
    public int which;
    public GameObject rune;
    private static int[] answers;
    //                                   {0,0,2,     0,0, 0, 1,  0,0,    2,0,   2,  0,0,0,0}
    private static int[] current;
    private Puzzle puzzle;
    private int[] rots = new int[] { 0, 90, 180, 270 };
    // Start is called before the first frame update
    void Start()
    {
        rune.SetActive(true);
        Debug.Log("which:" + which);
        answers = Constants.Getanswers(which);
        current = Constants.GetInit(which);
        puzzle = new Puzzle(answers,which);
        Debug.Log("Which0:" + puzzle.getAnswers()[0]);
        for (int num = 0; num<16; num++)
        {
            //board.SetActive(false);
            GameObject temp = board.GetComponentsInChildren<SpriteRenderer>()[num+1].gameObject;
            temp.transform.Rotate(0,0,(rots[current[num]]));
            board.SetActive(false);

        }
    }
    Vector3 worldPosition;
    int thres = 400;
    static bool cd = false;
    //Vector3 worldPositionA = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    // Update is called once per frame
    void Update()
    {
        int c = 0;
        Vector3 worldPositionA = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && !puzzle.getCd() && Mathf.Abs((board.transform.position - worldPositionA).magnitude) < thres)
        {
            board.SetActive(true);
            rune.GetComponent<SpriteRenderer>().sortingOrder = 4;
                //orlayer = 2;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            Debug.Log("Meeeeee" + hit.collider);
            //answers = Constants.Getanswers(which);
            Debug.Log("list: " + puzzle.getAnswers()[0]+puzzle.getAnswers()[15]+" "+which);
            //int c = 0;
            if (hit.collider != null && hit.collider.gameObject.layer.Equals(LayerMask.NameToLayer("Puzzle")))
            {
                GameObject temp = hit.collider.gameObject;
                puzzle.checkBoard(temp, board,rune);
                /*
                //Debug.Log(hit.collider.gameObject);
                Debug.Log(temp.transform.eulerAngles.z);
                temp.transform.Rotate(0, 0, 90f);
               
                for (int num = 0; num < 16; num++)
                {
                    //Debug.Log(num+":");
                    //Debug.Log(board.GetComponentsInChildren<SpriteRenderer>()[num + 1].gameObject.transform.eulerAngles.z + "v"+ answers[num]);
                    Debug.Log("a:"+answers[num]);
                    if (MathF.Abs(board.GetComponentsInChildren<SpriteRenderer>()[num + 1].gameObject.transform.eulerAngles.z - answers[num]) <49)
                    {
                        c++;
                    }
                    //Debug.Log(c);

                }
                Debug.Log(c);
                if (c == 16)
                {
                    Debug.Log("Closed"+ which);
                    cd = true;
                    board.SetActive(false);
                }
                */

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
