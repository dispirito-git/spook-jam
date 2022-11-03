using System.Collections;
using System.Collections.Generic;
using Mono.CompilerServices.SymbolWriter;
using UnityEngine;

public class playerWalk : MonoBehaviour
{
    private Rigidbody2D _RigidBody;

    private float _MoveInputH;

    public float Speed;

    private bool _IsWalking;

    private Animator animator;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
        _IsWalking = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _IsWalking = _isPlayerWalking(_MoveInputH);
         animator.SetBool("walking",_IsWalking);
         _MoveInputH = Input.GetAxisRaw("Horizontal");
        _RigidBody.velocity = new Vector2(_MoveInputH * Speed, 0); // updates horizontal movement based on input
        //gameObject.transform.localScale.x = -1;
    }

    
    /*
     * Determines if player is walking based on horizontal user input.
     */
    private bool _isPlayerWalking(float moveInputH)
    {
        // return Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow);
        return moveInputH != 0f;
    }
    

}
