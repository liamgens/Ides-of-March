using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caesar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
}
