using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutumnBin : MonoBehaviour
{
    public GameObject[] Zima;
    public GameObject[] Leto;
    public GameObject[] Jaro;
    public GameObject[] Podzim;
    public AudioSource audioData;
    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("Podzim"))
        {
            AutumnBeh.zivoty--;
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
        Debug.Log(AutumnBeh.pocet);
        Debug.Log(AutumnBeh.zivoty);
        NewOb();
    }

    void NewOb()
    {
        AutumnBeh.RandomOption = Random.Range(1, 15);
        if (AutumnBeh.RandomOption == 1)
        {
            Podzim[0].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 2)
        {
            Podzim[1].SetActive(true);
        }
        if (AutumnBeh.RandomOption == 3)
        {
            Podzim[2].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 4)
        {
            Podzim[3].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 5)
        {
            Podzim[4].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 6)
        {
            Leto[0].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 7)
        {
            Leto[1].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 8)
        {
            Leto[2].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 9)
        {
            Jaro[0].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 10)
        {
            Jaro[1].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 11)
        {
            Jaro[2].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 12)
        {
            Zima[0].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 13)
        {
            Zima[1].SetActive(true);
        }
        else if (AutumnBeh.RandomOption == 14)
        {
            Zima[2].SetActive(true);
        }
    }
}
