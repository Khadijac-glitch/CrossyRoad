using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennimi : MonoBehaviour
{
    void Start()
    {


    }


    void Update()
    {
        // D�place l'objet de gauche � droite
        float speed = 5.0f; // Vitesse 
        float zigzagSpeed = 2.0f; // Vitesse de zigzag
        float zigzagFrequency = 2.0f; // Fr�quence

        // Mouvement de gauche � droite
        transform.position += transform.right * speed * Time.deltaTime;

        // Mouvement en zigzag
        transform.position += transform.forward * Mathf.Sin(Time.time * zigzagFrequency) * zigzagSpeed * Time.deltaTime;
    }

    
}

