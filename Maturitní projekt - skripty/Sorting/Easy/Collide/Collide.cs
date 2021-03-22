using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public GameObject[] Rec;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("PlastP"))
        {
            GameBeh.scoreY++;
            TimerSort.timeS = TimerSort.timeS + 2;
        }
        else
        {
            GameBeh.scoreN++;
            TimerSort.timeS = TimerSort.timeS - 1;
        }
        for (int i = 0; i < Rec.Length; i++)
        {
            Rec[i].transform.position = new Vector3(0, 0, 0);
        }
        New();
    }
    
    void New()
    {
        GameBeh.randomSort = Random.Range(1, 4);
        if (GameBeh.randomSort == 1)
        {
            Rec[0].SetActive(true);
        }
        else if (GameBeh.randomSort == 2)
        {
            Rec[1].SetActive(true);
        }
        if (GameBeh.randomSort == 3)
        {
            Rec[2].SetActive(true);
        }
    }
    /* void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameBeh.randomSort == 1 && collision.gameObject.CompareTag("PlastK"))
        {
            GameBeh.scoreY++;
            Plast.SetActive(false);
            GameBeh.randomSort = Random.Range(1, 4);
            if (GameBeh.randomSort == 1)
            {
                Plast.transform.position = new Vector3(0, 0, 0);
                Plast.SetActive(true);
            }
            if (GameBeh.randomSort == 2)
            {
                Sklo.transform.position = new Vector3(0, 0, 0);
                Sklo.SetActive(true);
            }
            if (GameBeh.randomSort == 3)
            {
                Papir.transform.position = new Vector3(0, 0, 0);
                Papir.SetActive(true);
            }

        }
        else if (GameBeh.randomSort == 1 && collision.gameObject.CompareTag("SkloK"))
        {
            GameBeh.scoreN++;
            Plast.SetActive(false);
            GameBeh.randomSort = Random.Range(1, 4);
            if (GameBeh.randomSort == 1)
            {
                Plast.transform.position = new Vector3(0, 0, 0);
                Plast.SetActive(true);

            }
            if (GameBeh.randomSort == 2)
            {
                Sklo.transform.position = new Vector3(0, 0, 0);
                Sklo.SetActive(true);

            }
            if (GameBeh.randomSort == 3)
            {
                Papir.transform.position = new Vector3(0, 0, 0);
                Papir.SetActive(true);

            }
        }
        else if (GameBeh.randomSort == 1 && collision.gameObject.CompareTag("PapirK"))
        {
            GameBeh.scoreN++;
            Plast.SetActive(false);
            GameBeh.randomSort = Random.Range(1, 4);
            if (GameBeh.randomSort == 1)
            {
                Plast.transform.position = new Vector3(0, 0, 0);
                Plast.SetActive(true);

            }
            if (GameBeh.randomSort == 2)
            {
                Sklo.transform.position = new Vector3(0, 0, 0);
                Sklo.SetActive(true);

            }
            if (GameBeh.randomSort == 3)
            {
                Papir.transform.position = new Vector3(0, 0, 0);
                Papir.SetActive(true);

            }
        }
        if (GameBeh.randomSort == 2 && collision.gameObject.CompareTag("SkloK"))
        {
            GameBeh.scoreY++;
            Sklo.SetActive(false);
            GameBeh.randomSort = Random.Range(1, 4);
            if (GameBeh.randomSort == 1)
            {
                Plast.transform.position = new Vector3(0, 0, 0);
                Plast.SetActive(true);
            }
            if (GameBeh.randomSort == 2)
            {
                Sklo.transform.position = new Vector3(0, 0, 0);
                Sklo.SetActive(true);
            }
            if (GameBeh.randomSort == 3)
            {
                Papir.transform.position = new Vector3(0, 0, 0);
                Papir.SetActive(true);
            }
        }
        else if (GameBeh.randomSort == 2 && collision.gameObject.CompareTag("PapirK"))
        {
            GameBeh.scoreN++;
            Sklo.SetActive(false);
            GameBeh.randomSort = Random.Range(1, 4);
            if (GameBeh.randomSort == 1)
            {
                Plast.transform.position = new Vector3(0, 0, 0);
                Plast.SetActive(true);

            }
            if (GameBeh.randomSort == 2)
            {
                Sklo.transform.position = new Vector3(0, 0, 0);
                Sklo.SetActive(true);

            }
            if (GameBeh.randomSort == 3)
            {
                Papir.transform.position = new Vector3(0, 0, 0);
                Papir.SetActive(true);

            }

        }
        else if (GameBeh.randomSort == 2 && collision.gameObject.CompareTag("PlastK"))
        {
            GameBeh.scoreN++;
            Sklo.SetActive(false);
            GameBeh.randomSort = Random.Range(1, 4);
            if (GameBeh.randomSort == 1)
            {
                Plast.transform.position = new Vector3(0, 0, 0);
                Plast.SetActive(true);

            }
            if (GameBeh.randomSort == 2)
            {
                Sklo.transform.position = new Vector3(0, 0, 0);
                Sklo.SetActive(true);

            }
            if (GameBeh.randomSort == 3)
            {
                Papir.transform.position = new Vector3(0, 0, 0);
                Papir.SetActive(true);

            }

        }
        if (GameBeh.randomSort == 3 && collision.gameObject.CompareTag("PapirK"))
        {
            GameBeh.scoreY++;
            Papir.SetActive(false);
            GameBeh.randomSort = Random.Range(1, 4);
            if (GameBeh.randomSort == 1)
            {
                Plast.transform.position = new Vector3(0, 0, 0);
                Plast.SetActive(true);
            }
            if (GameBeh.randomSort == 2)
            {
                Sklo.transform.position = new Vector3(0, 0, 0);
                Sklo.SetActive(true);
            }
            if (GameBeh.randomSort == 3)
            {
                Papir.transform.position = new Vector3(0, 0, 0);
                Papir.SetActive(true);
            }
        }
        else if (GameBeh.randomSort == 3 && collision.gameObject.CompareTag("PlastK"))
        {
            GameBeh.scoreN++;
            Papir.SetActive(false);
            GameBeh.randomSort = Random.Range(1, 4);
            if (GameBeh.randomSort == 1)
            {
                Plast.transform.position = new Vector3(0, 0, 0);
                Plast.SetActive(true);

            }
            if (GameBeh.randomSort == 2)
            {
                Sklo.transform.position = new Vector3(0, 0, 0);
                Sklo.SetActive(true);

            }
            if (GameBeh.randomSort == 3)
            {
                Papir.transform.position = new Vector3(0, 0, 0);
                Papir.SetActive(true);

            }

        }
        else if (GameBeh.randomSort == 3 && collision.gameObject.CompareTag("SkloK"))
        {
            GameBeh.scoreN++;
            Papir.SetActive(false);
            GameBeh.randomSort = Random.Range(1, 4);
            if (GameBeh.randomSort == 1)
            {
                Plast.transform.position = new Vector3(0, 0, 0);
                Plast.SetActive(true);

            }
            if (GameBeh.randomSort == 2)
            {
                Sklo.transform.position = new Vector3(0, 0, 0);
                Sklo.SetActive(true);

            }
            if (GameBeh.randomSort == 3)
            {
                Papir.transform.position = new Vector3(0, 0, 0);
                Papir.SetActive(true);

            }

        }
            //Debug.Log(GameBeh.randomSort);
    }
}
} */
}