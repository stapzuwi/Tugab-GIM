using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject gameObject;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
