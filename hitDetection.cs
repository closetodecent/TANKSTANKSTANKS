using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class hitDetection : MonoBehaviour
{
    public int health = 2;

    private void OnCollisionEnter2D(Collision2D hitInfo)
    {
        Debug.Log("ow!");
       
        if (hitInfo.gameObject.tag == "Bullet")
        {
            health -= 1;
        }
        if (health == 0)
        {
            Debug.Log("oof");
            Destroy(gameObject);
           if (gameObject.tag == "Player")
            {
                SceneManager.LoadScene(0);
                SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

   
}
