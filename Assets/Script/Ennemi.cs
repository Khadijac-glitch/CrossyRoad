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
        // Déplace l'objet de gauche à droite
        float speed = 5.0f; // Vitesse 
        float zigzagSpeed = 2.0f; // Vitesse de zigzag
        float zigzagFrequency = 2.0f; // Fréquence

        // Mouvement de gauche à droite
        transform.position += transform.right * speed * Time.deltaTime;

        // Mouvement en zigzag
        transform.position += transform.forward * Mathf.Sin(Time.time * zigzagFrequency) * zigzagSpeed * Time.deltaTime;
    }

    
}

