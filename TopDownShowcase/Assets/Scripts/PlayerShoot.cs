using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float bulletSpeed = 0.1f;
    [SerializeField]
    float bulletLifetime = 2.0f;
    float timer = 0;
    [SerializeField]
    float shootDelay = 0.5f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // 0.016667 = 60fps
        //IF you click
        if (Input.GetButton("Fire1") && timer > 0.5f)
        {
            timer = 0; // reset the timer
            //shoot towards the mouse cursor
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            Vector3 mouseDir = mousePos - transform.position;
            //normalize the vector so we dont have wonky speeds
            mousePos.Normalize();
            //spawn in the bullet
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //push the bullet towards the mouse
            bullet.GetComponent<Rigidbody2D>().velocity = mouseDir * bulletSpeed;
            Destroy(bullet, bulletLifetime);
        }
    }
}
