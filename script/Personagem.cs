using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public Transform movimentacaoplayer;
    public float sensibilidade = 100.0f;
    public float velocidade = 5.0f;
    float rotx;
    float roty;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float X = Input.GetAxis("Horizontal");
        float Y = Input.GetAxis("Vertical");
        float MouseX = Input.GetAxis("Mouse X"); 
        float MouseY = Input.GetAxis("Mouse Y"); 

        Vector3 D = new Vector3(X, 0, Y);

        transform.Translate(D * velocidade * Time.deltaTime);

        rotx += MouseX * sensibilidade * Time.deltaTime;
        roty -= MouseY * sensibilidade * Time.deltaTime;

        transform.rotation = Quaternion.Euler(roty, rotx, 0);

        roty = Mathf.Clamp(roty, -80.0f, 80.0f); 
    }
}
