using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCar : MonoBehaviour
{
    public AudioSource audioData;
    public AudioSource audioData2;
    public AudioSource audioData3;
    float Yspeed = 0.3f;
    public static float skore;
    public GameObject score;
    public GameObject AutoPrek;
    public Text skoreCount;
    public Text Zivoty;
    float zivoty = 3;
    void Start()
    {
        GO_RF.PlayerAlive = true;
        Cursor.visible = false;
        skore = 0;
    }
    void Update()
    {
        Zivoty.text = string.Format("Pokusy: {0}", zivoty);
        skoreCount.text = string.Format("Skóre: {0}", skore);
        if (GO_RF.PlayerAlive == true)
        {
            float y = Yspeed * Input.GetAxis("Mouse Y");
            transform.position = transform.position + new Vector3(0, y, 0);
            if (transform.position.y >= 4.3)
            {
                transform.position = new Vector3(transform.position.x, 4.3f, transform.position.z);
            }
            else if (transform.position.y <= -3.8)
            {
                transform.position = new Vector3(transform.position.x, -3.8f, transform.position.z);
            }
        }
        if (zivoty == 0)
        {
            Destroy(gameObject);
            audioData2.Play();
            Cursor.visible = true;
            GO_RF.PlayerAlive = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RoadBlock")
        {
            if (zivoty > 0)
            {
                zivoty--;
                audioData.Play();
            }
            AutoPrek.SetActive(false);
        }

        if (collision.gameObject.tag == "Bod")
        {
            audioData3.Play();
            skore++;
            score.SetActive(false);

        }
    }
}
