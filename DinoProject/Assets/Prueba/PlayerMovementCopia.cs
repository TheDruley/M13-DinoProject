using UnityEngine;
using UnityEngine.Events;

public class PlayerMovementCopia : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    private CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    private bool jump = false;
    private bool crouch = false;


    private void Start()
    {
        controller = GetComponent<CharacterController2D>();
    }


    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("XboxJump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            animator.SetBool("IsCrouching", true);
        }
        else
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.CompareTag("Spike"))
        {
            col.transform.position = spawnPoint.position;
        }
        //if (col.gameObject.tag == "Player")
        //{
        //    GameObject dinoPlayer = new GameObject();
        //    dinoPlayer = GameObject.FindWithTag("Player");
        //    Destroy(dinoPlayer);
        //    Vector2 vector = new Vector2(0, 0);
        //    // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        //    Instantiate(dinoPlayer, vector, transform.rotation);
        //    //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //    //Destroy(col);
        //}
    }
}