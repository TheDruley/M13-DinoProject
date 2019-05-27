using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{

    public GameObject bloodSplash;
    public GameObject spawnPoint;

    private AudioSource audioPlayer;
    public AudioClip deathClip;


    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
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

            audioPlayer.clip = deathClip;
            audioPlayer.Play();

            //spawnPoint.GetComponent<SpawnerScript>().SpawnPlayer(gameObject);
            //StartCoroutine(waiter(1, gameObject));
            //Destroy(gameObject);

        }
    }


}
