using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaController : MonoBehaviour
{
    private Vector3 velocity;

    private bool moving;

    float dirX, moveSpeed = 3f;
    bool moveRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 2f)
        {
            moveRight = false;
        }
        
        if (transform.position.x < -2f)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        else if(!moveRight)
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        moving = true;
        col.collider.transform.SetParent(transform);
    }
    void OnCollisionExit2D(Collision2D col)
    {
        moving = true;
        col.collider.transform.SetParent(null);
    }

    private void FixedUpdate()
    {
        if (moving)
        {
            transform.position += (velocity * Time.deltaTime);
        }
    }
}
