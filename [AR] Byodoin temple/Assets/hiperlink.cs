using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hiperlink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenLink() 
    {
        Application.OpenURL("https://c2.etf.unsa.ba/course/view.php?id=44");
    }
}
