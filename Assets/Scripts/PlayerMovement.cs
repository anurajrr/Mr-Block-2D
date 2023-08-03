using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float Movespeed;
    Vector2 Movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal");   
        float MoveY = Input.GetAxis("Vertical");


        Movement = new Vector2(MoveX,MoveY).normalized;

        rb.AddForce(Movement * Movespeed );


    }
}
