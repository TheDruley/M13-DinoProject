using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    //public GameObject spawnPoint;
    public GameObject DinoPlayer;
    //public GameObject DinoPlayerTwo;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnPlayer(GameObject player)
    {
        //StartCoroutine(waiter(1, player));
    }


    IEnumerator waiter(int seconds, GameObject player)
    {
        yield return new WaitForSeconds(seconds);

        //Instantiate(DinoPlayer, gameObject.transform.position, Quaternion.identity);
    }
}
