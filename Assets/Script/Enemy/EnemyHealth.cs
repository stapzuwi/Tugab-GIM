using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject enemy;
    public int health;
    void Awake()
    {
        health = 3;
    }

    void Update()
    {
        if(health <= 0)
        {
            Destroy(enemy);
        }
    }
}
