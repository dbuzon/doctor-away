using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletObj;
    public GameObject shotEffect;
    public float bulletForce = 20f;
    AudioSource audioSource;
    public AudioClip gunshot;

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

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
        audioSource.PlayOneShot(gunshot, 0.7F);
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        Destroy(effect, 0.2f);
    }
}
