using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public float healthPercentage;
    public GameObject player;
    public GameObject enemy;
    public UnityEvent OnHealthChange;
    void Awake()
    {
        enemy = GameObject.FindWithTag("Enemy");
        currentHealth = maxHealth;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == enemy)
        {
            currentHealth -= 1;
            healthPercentage = (float) currentHealth/ (float) maxHealth;
            OnHealthChange.Invoke();
            if(currentHealth <= 0)
            {

                Destroy(player);
            }
        }
    }
}
