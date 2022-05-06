using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class breakableWall : MonoBehaviour
{

    public Tilemap tilemap;
    public float hitChanger;
    private void Start()
    {
        tilemap = GetComponent<Tilemap>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("BreakableWall Hit!!");

            Vector3 hitPosition = Vector3.zero;
            foreach(ContactPoint2D hit in collision.contacts)
            {
                Debug.Log("RUN!");
                hitPosition.x = hit.point.x + hitChanger * hit.normal.x;
                hitPosition.y = hit.point.y + hitChanger * hit.normal.y;
                tilemap.SetTile(tilemap.WorldToCell(hitPosition), null);
            }
        }
    }
}
