using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float moveSpeed = 2f;

   
    
    void Start()
    {
       
    }

    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xAxis = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zAxis = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xAxis, 0, zAxis);
    }
}
