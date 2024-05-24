using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2D;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

  
    void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * 5, rigidbody2D.velocity.y);
    }

}
