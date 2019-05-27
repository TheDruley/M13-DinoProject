using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{

    public GameObject bloodSplash;
    public GameObject spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Muerte"))
        {
            Instantiate(bloodSplash,gameObject.transform.position, Quaternion.identity);
            gameObject.transform.position = spawnPoint.transform.position;
            
            //spawnPoint.GetComponent<SpawnerScript>().SpawnPlayer(gameObject);
            //StartCoroutine(waiter(1, gameObject));
            //Destroy(gameObject);
                
        }
    }


}
