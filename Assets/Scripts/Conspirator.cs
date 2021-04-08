using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conspirator : MonoBehaviour
{
    public Transform player;
    private Vector2 movement;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
       rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate() {
        moveEnemy(movement);
    }

    void moveEnemy(Vector2 direction)
    {
       rb.MovePosition((Vector2)transform.position + (direction * 5f * Time.deltaTime));
    }
}
