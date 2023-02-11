using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fenix : MonoBehaviour
{
    public GameObject planeForVideo;

    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        planeForVideo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "feniks")
                {
                    if(planeForVideo.activeSelf) planeForVideo.SetActive(false);
                    else planeForVideo.SetActive(true);
                }
            }
        }
    }
}
