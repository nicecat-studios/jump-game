using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Rigidbody2D rbody;

    public static float movementSpeed;
    public static float jumpForce;

    void Start()
    {
        rbody = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }
}