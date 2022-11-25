using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class playback : MonoBehaviour
{
    public VideoPlayer video;
    public static bool playingVideo = false;

    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
       video = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "PlaneZaVideo")
                {
                    if(!playingVideo)
                    {
                        video.Play();
                        playingVideo = true;
                    }
                    else 
                    {
                        video.Pause();
                        playingVideo = false;
                    }
                }
            }
        }
    }
}
