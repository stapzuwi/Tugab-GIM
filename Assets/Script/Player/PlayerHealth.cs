using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public GameObject player;
    public GameObject enemy;
    void Awake()
    {
        enemy = GameObject.FindWithTag("Enemy");
        currentHealth = maxHealth;
    }

    void Update()
    {
    
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == enemy)
        {
            currentHealth -= 1;
            if(currentHealth <= 0)
            {
                Destroy(player);
            }
        }
    }
}
