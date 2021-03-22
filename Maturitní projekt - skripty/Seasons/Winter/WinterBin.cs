using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterBin : MonoBehaviour
{
    public GameObject[] Zima;
    public GameObject[] Leto;
    public GameObject[] Jaro;
    public GameObject[] Podzim;
    public AudioSource audioData;
    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("Zima"))
        {
            WinterBeh.zivoty--;
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
        Debug.Log(WinterBeh.pocet);
        Debug.Log(WinterBeh.zivoty);
        NewOb();
    }

    void NewOb()
    {
        WinterBeh.RandomOption = Random.Range(1, 15);
        if (WinterBeh.RandomOption == 1)
        {
            Zima[0].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 2)
        {
            Zima[1].SetActive(true);
        }
        if (WinterBeh.RandomOption == 3)
        {
            Zima[2].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 4)
        {
            Zima[3].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 5)
        {
            Zima[4].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 6)
        {
            Leto[0].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 7)
        {
            Leto[1].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 8)
        {
            Leto[2].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 9)
        {
            Jaro[0].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 10)
        {
            Jaro[1].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 11)
        {
            Jaro[2].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 12)
        {
            Podzim[0].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 13)
        {
            Podzim[1].SetActive(true);
        }
        else if (WinterBeh.RandomOption == 14)
        {
            Podzim[2].SetActive(true);
        }
    }
}
