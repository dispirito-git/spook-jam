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
    private InterObj me;
    // Start is called before the first frame update
    void Start()
    {
        me = new InterObj(transform.gameObject);
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
    static bool cd = false;
    //Vector3 worldPositionA = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    // Update is called once per frame
    void Update()
    {
        int c = 0;
        Vector3 worldPositionA = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (me.isClicked() && !puzzle.getCd())
        {
            board.SetActive(true);
            rune.GetComponent<SpriteRenderer>().sortingOrder = 4;
        }
        if (board.activeSelf && Input.GetMouseButtonDown(0)) { 
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            Debug.Log("Meeeeee" + hit.collider);
            //answers = Constants.Getanswers(which);
            //Debug.Log("list: " + puzzle.getAnswers()[0]+puzzle.getAnswers()[15]+" "+which);
            //int c = 0;
            if (hit.collider != null && hit.collider.gameObject.layer.Equals(LayerMask.NameToLayer("Puzzle")))
            {
                Debug.Log("Huh?");
                GameObject temp = hit.collider.gameObject;
                puzzle.checkBoard(temp, board,rune);
               
            }
        }
        


    }
}
