using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBin : MonoBehaviour
{
    public GameObject[] Zima;
    public GameObject[] Leto;
    public GameObject[] Jaro;
    public GameObject[] Podzim;
    public AudioSource audioData;
    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("Jaro"))
        {
            SpringBeh.zivoty--;
            audioData.Play();
        }
        for (int i = 0; i < Zima.Length; i++)
        {
            Zima[i].transform.position = new Vector3(0, -4, 0);
        }
        for (int j = 0; j < Leto.Length; j++)
        {
            Leto[j].transform.position = new Vector3(0, -4, 0);
        }
        for (int k = 0; k < Jaro.Length; k++)
        {
            Jaro[k].transform.position = new Vector3(0, -4, 0);
        }
        for (int l = 0; l < Podzim.Length; l++)
        {
            Podzim[l].transform.position = new Vector3(0, -4, 0);
        }
        Debug.Log(SpringBeh.pocet);
        Debug.Log(SpringBeh.zivoty);
        NewOb();
    }

    void NewOb()
    {
        SpringBeh.RandomOption = Random.Range(1, 15);
        if (SpringBeh.RandomOption == 1)
        {
            Jaro[0].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 2)
        {
            Jaro[1].SetActive(true);
        }
        if (SpringBeh.RandomOption == 3)
        {
            Jaro[2].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 4)
        {
            Jaro[3].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 5)
        {
            Jaro[4].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 6)
        {
            Podzim[0].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 7)
        {
            Podzim[1].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 8)
        {
            Podzim[2].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 9)
        {
            Leto[0].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 10)
        {
            Leto[1].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 11)
        {
            Leto[2].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 12)
        {
            Zima[0].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 13)
        {
            Zima[1].SetActive(true);
        }
        else if (SpringBeh.RandomOption == 14)
        {
            Zima[2].SetActive(true);
        }
    }
}
