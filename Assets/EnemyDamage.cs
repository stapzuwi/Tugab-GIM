using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    public GameObject player;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            playerHealth.currentHealth -= damage;
        }
    }
}
