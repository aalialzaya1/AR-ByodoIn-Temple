using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajnik : MonoBehaviour
{
    public GameObject planeForText;

    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        planeForText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "cajnik")
                {
                    if(planeForText.activeSelf) planeForText.SetActive(false);
                    else planeForText.SetActive(true);
                }
            }
        }
    }
}
