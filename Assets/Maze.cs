using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public GameObject launch;
    private InterObj la;
    public GameObject board;
    public GameObject miniPlayer;
    public int step;
    public GameObject goal;
    // Start is called before the first frame update
    void Start()
    {
        board.SetActive(false);
        la = new InterObj(launch.transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (la.isClicked() && !board.activeSelf)
        {
            board.SetActive(true);
            transform.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 14;
        }
        if (board.activeSelf)
        {
            Vector2 dir = new Vector2(0, 0);
            if (!Input.GetKeyDown(0))
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    //Debug.Log("Down");
                    //dir = new Vector2(0, -step);
                    miniPlayer.transform.Translate(new Vector3(0, -step), Space.Self);
                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    //Debug.Log("Up");
                    //dir = new Vector2(0, step);
                    miniPlayer.transform.Translate(new Vector3(0, step), Space.Self);
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    //Debug.Log("Left");
                    //dir = new Vector2(-step, 0);
                    miniPlayer.transform.Translate(new Vector3(-step, 0), Space.Self);

                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    //Debug.Log("Right");
                    //dir = new Vector2(step, 0);
                    miniPlayer.transform.Translate(new Vector3(step, 0), Space.World);
                }
                //miniPlayer.GetComponent<Rigidbody2D>().velocity =dir;
            }
        }
        /*if(MathF.Abs(goal.transform.position.magnitude - miniPlayer.transform.position.magnitude) < 1)
        {
            //Debug.Log("")
            board.SetActive(false);
            miniPlayer.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0); //just in case 
        }*/
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.name == goal.name)
        {
            board.SetActive(false);
            transform.gameObject.SetActive(false);
        }
    }
}
