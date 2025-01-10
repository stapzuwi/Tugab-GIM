using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            return;
        }
        else
        {
            Destroy(bullet);
        }
    }
    void Update()
    {
        if(transform.position.x < -12 || transform.position.x > 12 || transform.position.y < -6 || transform.position.y > 6)
        {
            Destroy(bullet);
        }
    }
}
