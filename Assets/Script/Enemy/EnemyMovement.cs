using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    private Rigidbody2D rb;
    private PlayerLocator playerLocator;
    private Vector2 targetDirection;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerLocator = GetComponent<PlayerLocator>();
    }

    void Update()
    {
        targetDirection = playerLocator.directionToPlayer;
        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, targetDirection);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed);
        rb.SetRotation(rotation);
        rb.velocity = transform.up*speed;
    }
}
