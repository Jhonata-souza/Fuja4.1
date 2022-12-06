using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public GameObject next;
    public GameObject text;

    bool perto; 
    // Start is called before the first frame update
    void Start()
    {
        perto = false;   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            perto = true;
            text.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            perto = false;
            text.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Interagir") && perto)
        {
            SceneManager.LoadScene("MenuFinal");
            text.SetActive(false);
        }   
    }
}
