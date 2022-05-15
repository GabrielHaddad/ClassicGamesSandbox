using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float startForce;

    bool canAddForce = true;

    void Awake() 
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() 
    {
        if (canAddForce)
        {
            rb2d.AddForce(transform.up * startForce);
            canAddForce = false;
        }
    }
}
