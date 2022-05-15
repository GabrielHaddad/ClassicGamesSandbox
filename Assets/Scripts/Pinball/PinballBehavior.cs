using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballBehavior : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float startForce;
    [SerializeField] float obstacleForce;
    [SerializeField] float invencibleTime;

    bool canAddForce = true;
    bool canHit = true;

    void Awake() 
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        if (Input.GetKeyDown("space"))
        {
            StartPinball();
        }
    }

    void StartPinball() 
    {
        if (canAddForce)
        {
            rb2d.AddForce(transform.up * startForce);
            canAddForce = false;
        }
    }

    IEnumerator ApplyForce(Vector3 targetPos)
    {
        canHit = false;
        Vector3 dir = targetPos - transform.position;
        dir = dir.normalized;
        rb2d.velocity = Vector3.zero;
        rb2d.angularVelocity = 0;
        rb2d.AddForce(dir * obstacleForce);

        yield return new WaitForSeconds(invencibleTime);

        canHit = true;

    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Obstacle") && canHit)
        {
            StartCoroutine(ApplyForce(other.gameObject.transform.position));
        }
    }

}
