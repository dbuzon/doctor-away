using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
  public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 move; // vector2 stores a x and a y

    // Update is called once per frame
    void Update() {
        // handle input
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        // handle movement
        rb.MovePosition(rb.position + move.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
