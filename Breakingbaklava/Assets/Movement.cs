using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public BoxCollider2D Groundcheck;
    public CharacterController Player;
    public float MoveSpeed = 15.0f;
    public float JumpForce = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)) {

            Player.Move(Vector2.right * MoveSpeed * Time.deltaTime);


        }
        if(Input.GetKey(KeyCode.A))
        {
            Player.Move(Vector2.left * MoveSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {

            Player.Move(Vector2.up * JumpForce * Time.deltaTime);

        }
        if(!isGrounded)
        {
            Player.Move(Vector2.down * 10 * Time.deltaTime);
        }

    }

    private bool isGrounded()
    {
        Physics2D.BoxCast(Groundcheck.bounds.center, Groundcheck.bounds.size, 0f, Vector2.down, .1f,) ;
    }
}
