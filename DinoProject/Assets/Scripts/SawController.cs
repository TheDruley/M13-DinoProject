using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SawController : MonoBehaviour {

    public Sprite blood1;
    public Sprite blood2;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("sangre");
            spriteRenderer.sprite = blood1;
            spriteRenderer.GetComponent<SpriteRenderer>().sprite = blood2;
        }
    }
}
