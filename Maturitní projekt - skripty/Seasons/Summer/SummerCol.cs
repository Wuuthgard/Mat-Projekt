using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummerCol : MonoBehaviour
{
    public GameObject[] Zima;
    public GameObject[] Leto;
    public GameObject[] Jaro;
    public GameObject[] Podzim;
    public AudioSource audioData;
    public AudioSource audioData2;
    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("Leto"))
        {
            SummerBeh.pocet++;
            audioData.Play();
        }
        else
        {
            SummerBeh.zivoty--;
            audioData2.Play();
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
        Debug.Log(SummerBeh.pocet);
        Debug.Log(SummerBeh.zivoty);
        NewOb();
    }

    void NewOb()
    {
        SummerBeh.RandomOption = Random.Range(1, 15);
        if (SummerBeh.RandomOption == 1)
        {
            Leto[0].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 2)
        {
            Leto[1].SetActive(true);
        }
        if (SummerBeh.RandomOption == 3)
        {
            Leto[2].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 4)
        {
            Leto[3].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 5)
        {
            Leto[4].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 6)
        {
            Podzim[0].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 7)
        {
            Podzim[1].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 8)
        {
            Podzim[2].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 9)
        {
            Jaro[0].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 10)
        {
            Jaro[1].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 11)
        {
            Jaro[2].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 12)
        {
            Zima[0].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 13)
        {
            Zima[1].SetActive(true);
        }
        else if (SummerBeh.RandomOption == 14)
        {
            Zima[2].SetActive(true);
        }
    }
}
