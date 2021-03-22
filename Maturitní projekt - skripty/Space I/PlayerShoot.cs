using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    float shotspeed = 0.5f;
    void Update()
    {
        transform.position += Vector3.up*shotspeed;
        if(transform.position.y >= 6)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
