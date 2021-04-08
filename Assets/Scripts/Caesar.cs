using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caesar : MonoBehaviour
{
    [SerializeField] private HealthBar health;

    void Start() 
    {
        health.setFullHealth();
    }

    void Update()
    {
        handleMovement();
    }

    void handleMovement()
    {
        float moveX = 0f;
        float moveY = 0f;
        float speed = 10f;
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }
        transform.position += new Vector3(moveX, moveY).normalized * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        health.takeHit();
    }

    private void OnCollisionStay2D(Collision2D other) {
        health.takeHit();
     }
}
