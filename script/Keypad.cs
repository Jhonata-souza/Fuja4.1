using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public GameObject player;
    public GameObject keypadOB;


    public GameObject animateOB;
    public Animator ANI;


    public Text textOB;
    public string answer = "321318";

    public AudioSource button;
    public AudioSource correct;
    public AudioSource wrong;

    public bool animate;


    void Start()
    {
        keypadOB.SetActive(false);

    }


    public void Number(int number)
    {
        textOB.text += number.ToString();
        button.Play();
    }

    public void Execute()
    {
        if (textOB.text == answer)
        {
            correct.Play();
            textOB.text = "Certo";

        }
        else
        {
            wrong.Play();
            textOB.text = "Errado";
        }


    }

    public void Clear()
    {
        {
            textOB.text = "";
            button.Play();
        }
    }

    public void Exit()
    {
        keypadOB.SetActive(false);
        player.GetComponent<Personagem>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()
    {
        if (textOB.text == "Certo" && animate)
        {
            ANI.SetBool("animate", true);
            //Debug.Log("its open");
        }


        if (keypadOB.activeInHierarchy)
        {
            player.GetComponent<Personagem>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }



    }

}
