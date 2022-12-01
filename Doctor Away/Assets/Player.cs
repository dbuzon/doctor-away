using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public int health = 5;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject deathEffect;
    
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.GetComponent<Enemy>() != null) {
            health--;
            hearts[health].sprite = emptyHeart; 
        }

        if (health <= 0) {
            Die();
        }
    }

    void Die() {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
