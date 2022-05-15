using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    [Header("Movement")]
    Vector2 moveInput;
    [SerializeField] float moveSpeed = 8f;

    [Header("Boundaries")]
    Vector2 minBounds;
    Vector2 maxBounds;
    [SerializeField] float paddingLeft = 0.5f;
    [SerializeField] float paddingRight = 0.5f;

    BoxCollider2D boxCollider2D;

    Vector3 firstPos;

    void Awake() 
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Start()
    {
        firstPos = transform.position;
        InitBounds();
    }

    void Update()
    {
        MovePlayer();
    }

    void InitBounds()
    {
        Camera mainCamera = Camera.main;
        minBounds = mainCamera.ViewportToWorldPoint(new Vector2(0, 0));
        maxBounds = mainCamera.ViewportToWorldPoint(new Vector2(1, 1));
    }

    void MovePlayer()
    {
        Vector2 delta = moveInput * moveSpeed * Time.deltaTime;
        Vector2 newPos = new Vector2();

        newPos.x = Mathf.Clamp(transform.position.x  + delta.x, minBounds.x + paddingLeft, maxBounds.x - paddingRight);
        newPos.y = transform.position.y;

        transform.position = newPos;
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnDrawGizmos() 
    {
        Vector3 cubeSize = new Vector3((maxBounds.x - minBounds.x) - (paddingLeft + paddingRight) , (maxBounds.y - minBounds.y), 0);
        Gizmos.DrawCube(firstPos, cubeSize);
    }
}
