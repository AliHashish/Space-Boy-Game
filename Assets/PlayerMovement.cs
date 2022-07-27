using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Rigidbody2D body;
    public Animator animator;

    // Some controls
    public float runSpeed = 40f;    
    float horizontalMove = 0f;      // movement on x-axis
    bool jump = false;
    bool crouch = false;


    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetAxisRaw("Horizontal"));  // Prints in terminal
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; // A: -1 , D: 1

        // by8yr speed el animator el 3mlnah
        // kelmet Speed mktooba hena zy el parameters henak
        // by5leeha equal horizontalMove
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }


        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    // Gets called every fixed amount of time
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))        // byshoof howa 3amelo hold wala la
        {
            // y2alel el gravity sa3etha
            body.gravityScale = 1;
        }
        else
        {
            // rg3ha lel default
            body.gravityScale = 3;
        }
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        // Move(el sor3a, crouch, jump)
        // Time.fixedDeltaTime btedman eno yt7rk b sor3a consistent
        jump = false;

    }

    public void OnLand()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        // isCrouching dh byrg3 mn el event mazboot
        animator.SetBool("IsCrouching", isCrouching);
    }
}
