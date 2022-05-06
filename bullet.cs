using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb2d;

    public int health;


    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = rb2d.transform.up * speed;
    }

    void Update()
    {

    }

   private void OnCollisionEnter2D (Collision2D hitInfo)
    {
         Debug.Log("bullet has collided");
        switch (hitInfo.gameObject.tag)
        {
            case "Enemy":
                Debug.Log("hit enemy");
                Destroy(gameObject);
                break;
            case "Player":
                Debug.Log("hit player");
                Destroy(gameObject);
                break;
            case "Walls":
                if (health > 0)
                {
                    health -= 1;
                }
                if (health == 0)
                {
                    Destroy(gameObject);
                }
                break;
            case "Bullet":
                Debug.Log("hit Other BillyBoi");
                Destroy(gameObject);
                break;

        }
    }

}
