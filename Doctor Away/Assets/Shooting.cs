using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletObj;
    public GameObject shotEffect;
    public float bulletForce = 20f;

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        GameObject effect = Instantiate(shotEffect, firePoint.position, firePoint.rotation);
        GameObject bullet = Instantiate(bulletObj, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        Destroy(effect, 0.2f);
    }
}
