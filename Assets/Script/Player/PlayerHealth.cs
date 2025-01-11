using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public float healthPercentage;
    public GameObject enemy;
    public UnityEvent OnHealthChange;
    void Awake()
    {
        enemy = GameObject.FindWithTag("Enemy");
        currentHealth = maxHealth;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        healthPercentage = (float) currentHealth/ (float) maxHealth;
        OnHealthChange.Invoke();
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
