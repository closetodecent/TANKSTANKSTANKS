using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

   public Transform firepoint;

   public GameObject bullet;

   
   public float fireRate;
   float lastShot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            shoot();
        }
    }

    void shoot ()
    {
        Debug.Log(Time.time);
       if (Time.time > fireRate + lastShot) {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            lastShot = Time.time;
        }
    }
}


