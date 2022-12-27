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

    private bool isLeft;

    //public GameObject board;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
        _IsWalking = false;
        animator = GetComponent<Animator>();
        isLeft = false;
    }

    // Update is called once per frame
    void Update()
    {
            checkFlip();
            _IsWalking = _isPlayerWalking(_MoveInputH);
            animator.SetBool("walking", _IsWalking);
            _MoveInputH = Input.GetAxisRaw("Horizontal");
            _RigidBody.velocity = new Vector2(_MoveInputH * Speed, 0); // updates horizontal movement based on inpu
    }

    
    /*
     * Determines if player is walking based on horizontal user input.
     */
    private bool _isPlayerWalking(float moveInputH)
    {
        // return Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow);
        return moveInputH != 0f;
    }

    private void checkFlip()
    {
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && !isLeft)
        {
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;
            isLeft = true;
        }

        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && isLeft)
        {
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;
            isLeft = false;
        }
    }

}
