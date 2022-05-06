using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlueTankAttack : MonoBehaviour
{
    public Transform firepoint;
    public Transform target;
    public Transform BlueTank;
    public GameObject bullet;
    public GameObject enemyGun;
    public float fireRate = 2f;
    float lastShot = 0f;
    float targetX;
    float targetY;
  

    public float speed;
    // Update is called once per frame
    void Update()
    {
        

        if (target != null)
        {
            
            
            float randomNumber = Random.Range(80, 120);
            float percent = randomNumber / 100;
            targetX = target.position.x - BlueTank.position.x;
            targetY = target.position.y - BlueTank.position.y;

            float angle =  Mathf.Atan2(targetY, targetX) * Mathf.Rad2Deg;
            enemyGun.transform.rotation = Quaternion.Euler(new Vector3(0, 0, (percent*angle) - 90));
            shoot();
            enemyGun.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        }

       
    }

    void shoot()
    {
        if (Time.time > fireRate + lastShot)
        {


            Instantiate(bullet, firepoint.position, firepoint.rotation);
            
            lastShot = Time.time;
        }
    }
    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            target = null;
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (target == null)
            {
                target = col.gameObject.transform;
            }
       }
    }

    
}
