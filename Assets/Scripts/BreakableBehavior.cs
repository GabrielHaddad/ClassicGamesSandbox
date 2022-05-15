using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBehavior : MonoBehaviour
{
    [SerializeField] int blockHP;
    [SerializeField] float invencibleTime;
    
    bool canHit = true;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Ball") && canHit)
        {
            StartCoroutine(ComputeDamage());
        }
    }

    IEnumerator ComputeDamage()
    {
        canHit = false;
        blockHP--;

        if (blockHP <= 0)
        {
            DestroyBlock();
        }

        yield return new WaitForSeconds(invencibleTime);
        canHit = true;
    }

    void DestroyBlock()
    {
        Destroy(gameObject);
    }
}
