using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SawController : MonoBehaviour
{

    public Sprite[] bloodLevel;
    public SpriteRenderer spriteController;
    private int cont;

    // Start is called before the first frame update
    void Start()
    {
        spriteController.GetComponent<SpriteRenderer>().sprite = bloodLevel[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            if (cont < 3)
            {
                cont++;
                spriteController.GetComponent<SpriteRenderer>().sprite = bloodLevel[cont];
            }
        }
    }
}
