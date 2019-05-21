using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    private bool jump = false;


    private void Start()
    {
        controller = GetComponent<CharacterController2D>();
    }


    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("XboxJump"))
        {
            jump = true;
        }

    }


    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}