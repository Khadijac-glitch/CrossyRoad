using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {


    }


    void Update()
    {
        // D�place l'objet de gauche � droite
        float speed = 5.0f; // Vitesse 
       

        // Mouvement de gauche � droite
        transform.position += -transform.right * speed * Time.deltaTime;

        // Mouvement en zigzag
        transform.position += transform.forward * Mathf.Sin(Time.time) * Time.deltaTime;
    }
}