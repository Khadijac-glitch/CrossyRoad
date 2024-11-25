using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveDistance = 1f;
    public float moveSpeed = 5f;
    private Vector3 targetPosition;
          void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // Contrôle avec les flèches
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                targetPosition += new Vector3(0, 0, moveDistance);
            if (Input.GetKeyDown(KeyCode.RightArrow))
                targetPosition -= new Vector3(0, 0, moveDistance);
            if (Input.GetKeyDown(KeyCode.DownArrow))   
                targetPosition -= new Vector3(moveDistance, 0, 0);
            if (Input.GetKeyDown(KeyCode.UpArrow))
                targetPosition += new Vector3(moveDistance, 0, 0);
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}