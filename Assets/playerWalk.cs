using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalk : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    private float moveInputH;

    public float speed; 
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInputH = Input.GetAxisRaw("Horizontal");
        rigidBody.velocity = new Vector2(moveInputH * speed, 0); // updates horizontal movement based on input
    }
}
