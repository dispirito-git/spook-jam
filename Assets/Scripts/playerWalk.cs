using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalk : MonoBehaviour
{
    private Rigidbody2D _RigidBody;

    private float _MoveInputH;

    public float Speed;

    private bool _IsWalking;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _MoveInputH = Input.GetAxisRaw("Horizontal");
        _RigidBody.velocity = new Vector2(_MoveInputH * Speed, 0); // updates horizontal movement based on input
        _IsWalking = _isPlayerWalking(_MoveInputH);
    }

    
    /*
     * Determines if player is walking based on horizontal user input.
     */
    private bool _isPlayerWalking(float moveInputH)
    {
        return moveInputH != 0f;
    }
}
