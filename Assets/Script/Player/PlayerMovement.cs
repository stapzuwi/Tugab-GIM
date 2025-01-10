using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float playerBorderDistance;
    private Rigidbody2D rb;
    private Vector2 movementInput;
    public Camera cam;
    public Vector2 mousePos;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = movementInput.normalized*speed;
        PreventPlayerGoingOffScreen();

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x)*Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    private void PreventPlayerGoingOffScreen()
    {
        Vector2 screenPosition = cam.WorldToScreenPoint(transform.position);

        if((screenPosition.x < playerBorderDistance && rb.velocity.x < 0) || (screenPosition.x > cam.pixelWidth - playerBorderDistance && rb.velocity.x > 0))
        {
            rb.velocity = new Vector2(0,rb.velocity.y);
        }
        if((screenPosition.y < playerBorderDistance && rb.velocity.y < 0) || (screenPosition.y > cam.pixelHeight - playerBorderDistance && rb.velocity.y > 0))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }

    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }
}