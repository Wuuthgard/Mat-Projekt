using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public AudioSource audioData;
    public AudioSource audioData2;
    public Transform shotspawn;
    float Xspeed = 0.4f;
    float attackspeed = 0.5f;
    public GameObject shot;
    float fire;
    void Start()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        GO.PlayerAlive = true;
        if(EnemyAI.wave==2)
        {
            attackspeed = attackspeed + 0.10f;
        }
        else if (EnemyAI.wave == 3)
        {
            attackspeed = attackspeed + 0.20f;
        }
        else if(EnemyAI.wave == 4)
        {
            attackspeed = attackspeed + 0.30f;
        }
        else if(EnemyAI.wave == 5)
        {
            attackspeed = attackspeed + 0.45f;
        }
        else if (EnemyAI.wave == 6)
        {
            attackspeed = attackspeed + 0.50f;
        }
        else if (EnemyAI.wave == 7)
        {
            attackspeed = attackspeed + 0.55f;
        }
        else if (EnemyAI.wave == 8)
        {
            attackspeed = attackspeed + 0.60f;
        }
        else if (EnemyAI.wave == 9)
        {
            attackspeed = attackspeed + 0.65f;
        }
        else if (EnemyAI.wave >= 10)
        {
            attackspeed = attackspeed + 0.70f;
        }
    }

    void Update()
    {
        /*if (Input.mousePosition.x >= boundL && Input.mousePosition.y >= boundB )
             {
                 Vector3 mousePos = Input.mousePosition;
                 mousePos.z = Camera.main.nearClipPlane;
                 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

                 transform.position = worldPosition;
         }

         */
        /*else if (Input.mousePosition.x <= boundL)
        {
            mousePos.x = boundL;
        }

        else if (Input.mousePosition.x >= boundR)
        {
            mousePos.x = boundR;
        }*/
        if (GO.PlayerAlive == true)
        {
                float X = Xspeed * Input.GetAxis("Mouse X");
                transform.position = transform.position + new Vector3(X, 0, 0);
                if (transform.position.x >= 7.3f)
                {
                    transform.position = new Vector3(7.3f, transform.position.y, 0);
                }
                else if (transform.position.x <= -7.3)
                {
                    transform.position = new Vector3(-7.3f, transform.position.y, 0);
                }

            if (Time.time > fire)
            {
                audioData.Play();
                fire = Time.time + attackspeed;
                Instantiate(shot, shotspawn.position, shotspawn.rotation);
            }
        }
        else
        {
            Destroy(gameObject);
            audioData2.Play();
        }
        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            GO.PlayerAlive = false;
            audioData2.Play();
        }
    }
}
