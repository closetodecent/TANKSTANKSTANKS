using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMagic : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 5.0f;
    float angle;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var destructionTime = 5;

            Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
           



            Vector2 myPos = new Vector2(transform.position.x, transform.position.y  );
            
                Vector2 direction = target - myPos;
            direction.Normalize();
            //Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
            GameObject projectile = (GameObject)Instantiate(bullet, myPos, Quaternion.identity);
            projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
            Destroy(projectile, destructionTime);
            
        }
    }

  


}
