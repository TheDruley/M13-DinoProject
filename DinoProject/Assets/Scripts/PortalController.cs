﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //void OnCollisionEnter2D(Collision2D col)
    ////void OnTrigger2D(Collision2D col)
    //{
    //    if (col.gameObject.tag.Equals("Player"))
    //    {
    //        SceneManager.LoadScene("Map2");
    //    }
    //}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                SceneManager.LoadScene("Map4");
            }
            else if (SceneManager.GetActiveScene().name == "Map4")
            {
                SceneManager.LoadScene("Map2");
            }
            else if (SceneManager.GetActiveScene().name == "Map2")
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}