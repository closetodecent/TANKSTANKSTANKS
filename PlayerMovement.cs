using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
  public float movespeed = 5f;

  public Rigidbody2D rb2d;

    public Transform redtankbase;

    float angle;
  Vector2 movement;

    Vector2 start;
    // Update is called once per frame
    void Update()
    {
        //inputhandeling
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        start.x = 0;
        start.y = 1;
        angle = Vector2.Angle(movement,start);
        if (movement.x > 0)
        {
            angle *= -1;
        }
        var rotation = redtankbase.rotation.eulerAngles;
        rotation.z = angle;
        redtankbase.rotation = Quaternion.Euler(rotation);

        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } else
            {
                SceneManager.LoadScene(0);
            }

        }
    }

    void FixedUpdate()
    {
        //Movement
        rb2d.MovePosition(rb2d.position + movement * movespeed * Time.deltaTime);
    }
}
