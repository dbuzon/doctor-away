using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int health = 5;
    //public GameObject deathEffect;

    void OnCollisionEnter2D(Collision2D collision) {
        health--;
        if (health <= 0) {
            Die();
        }
    }

    void Die() {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
