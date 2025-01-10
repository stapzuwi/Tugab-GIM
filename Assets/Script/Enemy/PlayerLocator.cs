using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocator : MonoBehaviour
{
    public Vector2 directionToPlayer {get; private set;}
    private Transform player;

    void Awake()
    {
        player = FindObjectOfType<PlayerMovement>().transform; 
    }

    void Update()
    {
        Vector2 enemyToPlayerVector = player.position - transform.position;
        directionToPlayer = enemyToPlayerVector.normalized;
    }
}
