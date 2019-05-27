using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxController : MonoBehaviour
{

    [Range(0f, 1f)]
    public float parallaxSpeed = 0.005f;
    public RawImage clouds;
    public RawImage farClouds;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float finalSpeed = parallaxSpeed * Time.deltaTime;
        clouds.uvRect = new Rect(clouds.uvRect.x + finalSpeed * 2, 0f, 1f, 1f);
        farClouds.uvRect = new Rect(farClouds.uvRect.x + finalSpeed, 0, 1f, 1f);
    }
}
