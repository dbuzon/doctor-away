using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour{
   
    public Rigidbody2D rb;
    public Camera cam;
    public Transform objectToFollow;
    
    Vector2 mousePos;

    // Update is called once per frame
    void Update() {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate() {
    
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        if (angle >= 90f || angle <= -90f) {
            transform.localScale = new Vector3(1.3f, -1.3f, 1.3f); 
        } 
        else {
            transform.localScale = new Vector3(1.3f, 1.3f, 1.3f); 
        }
        // handle movement
        if (objectToFollow != null) {
            rb.MovePosition(objectToFollow.position);
        }
        else {
            Destroy(gameObject);
        }
    }
}
