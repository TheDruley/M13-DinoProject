using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    private bool jump = false;
    private bool crouch = false;

    [SerializeField] private Collider2D m_CrouchHeadCollider;
    [SerializeField] private Collider2D m_CrouchBodyCollider;

    [SerializeField] private Collider2D m_StandUpHeadCollider;
    [SerializeField] private Collider2D m_StandUpBodyCollider;

    private void Start()
    {
        controller = GetComponent<CharacterController2D>();
    }


    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (horizontalMove > 0)
        {
            if (animator.GetBool("IsJumping"))
            {
                Debug.Log("Caminar.mp3");
            }
        }

        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("XboxJump"))
        {
            Debug.Log("Salto.mp3");
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            animator.SetBool("IsCrouching", true);
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
            animator.SetBool("IsCrouching", false);
        }

    }

    public void OnLanding()
    {
        //Debug.Log("TocaElSuelo.mp3");
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", false);
    }


    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}