using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class padanjeLatica : MonoBehaviour
{
    public ParticleSystem latice;

    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
       latice = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "drvo")
                {
                    if(latice.isPlaying)
                    {
                        latice.Stop();

                    }
                    else 
                    {
                        latice.Play();
                    }
                }
            }
        }
    }
}
