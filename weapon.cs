using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

   public Transform firepoint;

   public GameObject bullet;

   public float speed;
float fireRate = 1f;
float lastShot = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            shoot();
        }
    }

    void shoot ()
    {
        if (Time.time > fireRate + lastShot) {

        
         Instantiate(bullet, firepoint.position, firepoint.rotation);
        lastShot =Time.time;
        }
    }
}


