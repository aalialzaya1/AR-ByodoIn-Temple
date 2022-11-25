using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class budda : MonoBehaviour
{
    public Image slikaBude;

    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        slikaBude.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "statua")
                {
                    if(slikaBude.enabled == false) slikaBude.enabled = true;
                    else slikaBude.enabled = false;
                }
            }
        }
    }
}
