﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PinchoController : MonoBehaviour
{
    // Start is called before the first frame update

    //GameObject dinoPlayer;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.transform.CompareTag("Player"))
        //{
        //    col.transform.position = spawnPoint.position;
        //}
        if (col.gameObject.tag == "Player")
        {
            GameObject dinoPlayer = new GameObject();
            dinoPlayer = GameObject.FindWithTag("Player");
            Destroy(dinoPlayer);
            Vector2 vector = new Vector2(0, 0);
            // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
            Instantiate(dinoPlayer, vector, transform.rotation);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Destroy(col);
        }
    }

    
}
