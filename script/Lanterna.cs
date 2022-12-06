using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    public GameObject flashlight;
    bool on;
    bool off;
    // Start is called before the first frame update
    void Start()
    {
        off = true;
        flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(off && Input.GetButtonDown("F"))
        {
            flashlight.SetActive(true);
            on = true;
            off = false;
        }

        else if(on && Input.GetButtonDown("F"))
        {
            flashlight.SetActive(false);
            off = true;
            on = false;
        }
    }
}
