using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour

{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float shotInterval;
    public float timeUntilNextShot;
    public bool currentlyShooting;

    [SerializeField] private float bulletForce;

    void Update()
    {
        if(timeUntilNextShot > 0)
        {
            timeUntilNextShot -= Time.deltaTime;
        }
        if(currentlyShooting)
        {
            if(timeUntilNextShot <= 0)
            {
                timeUntilNextShot = shotInterval;
                Shoot();
            }
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up*bulletForce, ForceMode2D.Impulse);
    }

    public void OnFire(InputValue inputValue)
    {
        currentlyShooting = inputValue.isPressed;
    }
}
