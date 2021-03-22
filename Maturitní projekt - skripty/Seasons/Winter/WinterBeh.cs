using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinterBeh : MonoBehaviour
{
    public GameObject[] Layers;
    public GameObject[] Zima;
    public GameObject[] Leto;
    public GameObject[] Jaro;
    public GameObject[] Podzim;
    public Text gO;
    public Text pokusy;
    public static int zivoty;
    public static int pocet;
    public static int RandomOption;
    void Start()
    {
        zivoty = 3;
        pocet = 0;
        for (int i = 0; i < Zima.Length; i++)
         {
            Zima[i].SetActive(false);
         }
        for (int j = 0; j < Leto.Length; j++)
        {
            Leto[j].SetActive(false);
        }
        for (int j = 0; j < Jaro.Length; j++)
        {
            Jaro[j].SetActive(false);
        }
        for (int j = 0; j < Podzim.Length; j++)
        {
            Podzim[j].SetActive(false);
        }
        Cursor.visible = false;
        RandomOption = Random.Range(1, 15);
        if (RandomOption==1)
        {
            Zima[0].SetActive(true);
        }
        else if (RandomOption == 2)
        {
            Zima[1].SetActive(true);
        }
        else if (RandomOption == 3)
        {
            Zima[2].SetActive(true);
        }
        else if (RandomOption == 4)
        {
            Zima[3].SetActive(true);
        }
        else if (RandomOption == 5)
        {
            Zima[4].SetActive(true);
        }
        else if (RandomOption == 6)
        {
            Leto[0].SetActive(true);
        }
        else if (RandomOption == 7)
        {
            Leto[1].SetActive(true);
        }
        else if (RandomOption == 8)
        {
            Leto[2].SetActive(true);
        }
        else if (RandomOption == 9)
        {
            Jaro[0].SetActive(true);
        }
        else if (RandomOption == 10)
        {
            Jaro[1].SetActive(true);
        }
        else if (RandomOption == 11)
        {
            Jaro[2].SetActive(true);
        }
        else if (RandomOption == 12)
        {
            Podzim[0].SetActive(true);
        }
        else if (RandomOption == 13)
        {
            Podzim[1].SetActive(true);
        }
        else if (RandomOption == 14)
        {
            Podzim[2].SetActive(true);
        }
        transform.position = new Vector3(0, -4, 0);
    }
    void Update()
    {
        pokusy.text = string.Format("Pokusy: ") + zivoty;
        if (gameObject != null && zivoty>0)
        {
            float x = 0.15f * Input.GetAxis("Mouse X");
            transform.position = transform.position + new Vector3(x, 0, 0);
        }
        if (zivoty==0)
        {
            GameOver();
        }
        if (pocet==0)
        {
            Layers[0].SetActive(true);
            Layers[1].SetActive(false);
            Layers[2].SetActive(false);
            Layers[3].SetActive(false);
            Layers[4].SetActive(false);
            Layers[5].SetActive(false);
        }
        else if (pocet == 1)
        {
            Layers[0].SetActive(false);
            Layers[1].SetActive(true);
        }
        else if (pocet == 2)
        {
            Layers[1].SetActive(false);
            Layers[2].SetActive(true);
        }
        else if (pocet == 3)
        {
            Layers[2].SetActive(false);
            Layers[3].SetActive(true);
        }
        else if (pocet == 4)
        {
            Layers[3].SetActive(false);
            Layers[4].SetActive(true);
        }
        else if (pocet == 5)
        {
            Layers[4].SetActive(false);
            Layers[5].SetActive(true);
            Win();
        }
    }
    
    void Win()
    {
        Coroutine cas = null;
        cas = StartCoroutine(Casovac(3));
        for (int i = 0; i < Zima.Length; i++)
        {
            Zima[i].SetActive(false);
        }
        for (int j = 0; j < Leto.Length; j++)
        {
            Leto[j].SetActive(false);
        }
        for (int j = 0; j < Podzim.Length; j++)
        {
            Podzim[j].SetActive(false);
        }
        for (int j = 0; j < Jaro.Length; j++)
        {
            Jaro[j].SetActive(false);
        }
        IEnumerator Casovac(int time)
        {
            while (time > 0)
            {
                gO.enabled = true;
                if (time == 3)
                {
                    gO.text = string.Format("Načítá se scéna s výhrou.");
                }
                else if (time == 2)
                {
                    gO.text = string.Format("Načítá se scéna s výhrou..");
                }
                else if (time == 1)
                {
                    gO.text = string.Format("Načítá se scéna s výhrou...");
                }
                time--;
                yield return new WaitForSeconds(1);
            }
            Cursor.visible = true;
            SceneManager.LoadScene("Zima Win");
        }
    }

    void GameOver()
    {
        Coroutine cas = null;
        cas = StartCoroutine(Casovac(3));
        for (int i = 0; i < Zima.Length; i++)
        {
            Zima[i].SetActive(false);
        }
        for (int j = 0; j < Leto.Length; j++)
        {
            Leto[j].SetActive(false);
        }
        IEnumerator Casovac(int time)
        {
            while (time > 0)
            {
                gO.enabled = true;
                if (time == 3)
                {
                    gO.text = string.Format("Načítá se scéna s prohrou.");
                }
                else if (time == 2)
                {
                    gO.text = string.Format("Načítá se scéna s prohrou..");
                }
                else if (time == 1)
                {
                    gO.text = string.Format("Načítá se scéna s prohrou...");
                }
                time--;
                yield return new WaitForSeconds(1);
            }
            Cursor.visible = true;
            SceneManager.LoadScene("Zima GO");
        }
    }
}