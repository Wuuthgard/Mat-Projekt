using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideMed : MonoBehaviour
{
    public GameObject[] Rec;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("PlastP"))
        {
            GameBehMed.scoreY++;
            TimerSortMed.timeS = TimerSortMed.timeS + 2;
        }
        else
        {
            GameBehMed.scoreN++;
            TimerSortMed.timeS = TimerSortMed.timeS - 1;
        }
        for (int i = 0; i < Rec.Length; i++)
        {
            Rec[i].transform.position = new Vector3(0, 0, 0);
        }
        New();
    }

    void New()
    {
        GameBehMed.randomSort = Random.Range(1, 5);
        if (GameBehMed.randomSort == 1)
        {
            Rec[0].SetActive(true);
        }
        else if (GameBehMed.randomSort == 2)
        {
            Rec[1].SetActive(true);
        }
        if (GameBehMed.randomSort == 3)
        {
            Rec[2].SetActive(true);
        }
        if (GameBehMed.randomSort == 4)
        {
            Rec[3].SetActive(true);
        }
    }
    /* public GameObject Plast;
     public GameObject Sklo;
     public GameObject Papir;
     public GameObject Elektro;
     void OnTriggerEnter2D(Collider2D collision)
     {
         if (GameBehMed.randomSort == 1)
         {
             if (collision.gameObject.CompareTag("PlastK"))
             {
                 GameBehMed.scoreY++;
                 Plast.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }

             }
             else if (collision.gameObject.CompareTag("ElektroK"))
             {
                 GameBehMed.scoreN++;
                 Plast.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
             else if (collision.gameObject.CompareTag("SkloK"))
             {
                 GameBehMed.scoreN++;
                 Plast.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
             else if (collision.gameObject.CompareTag("PapirK"))
             {
                 GameBehMed.scoreN++;
                 Plast.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
         }
         if (GameBehMed.randomSort == 2)
         {
             if (collision.gameObject.CompareTag("SkloK"))
             {
                 GameBehMed.scoreY++;
                 Sklo.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }

             }
             else if (collision.gameObject.CompareTag("ElektroK"))
             {
                 GameBehMed.scoreN++;
                 Sklo.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
             else if (collision.gameObject.CompareTag("PapirK"))
             {
                 GameBehMed.scoreN++;
                 Sklo.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }

             }
             else if (collision.gameObject.CompareTag("PlastK"))
             {
                 GameBehMed.scoreN++;
                 Sklo.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
         }
         if (GameBehMed.randomSort == 3)
         {
             if (collision.gameObject.CompareTag("PapirK"))
             {
                 GameBehMed.scoreY++;
                 Papir.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
             else if (collision.gameObject.CompareTag("ElektroK"))
             {
                 GameBehMed.scoreN++;
                 Papir.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
             else if (collision.gameObject.CompareTag("PlastK"))
             {
                 GameBehMed.scoreN++;
                 Papir.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
             else if (collision.gameObject.CompareTag("SkloK"))
             {
                 GameBehMed.scoreN++;
                 Papir.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
         }
         if (GameBehMed.randomSort == 4)
         {
             if (collision.gameObject.CompareTag("ElektroK"))
             {
                 GameBehMed.scoreY++;
                 Elektro.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);
                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
             else if (collision.gameObject.CompareTag("PapirK"))
             {
                 GameBehMed.scoreN++;
                 Elektro.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
             else if (collision.gameObject.CompareTag("PlastK"))
             {
                 GameBehMed.scoreN++;
                 Elektro.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
             else if (collision.gameObject.CompareTag("SkloK"))
             {
                 GameBehMed.scoreN++;
                 Elektro.SetActive(false);
                 GameBehMed.randomSort = Random.Range(1, 5);
                 if (GameBehMed.randomSort == 1)
                 {
                     Plast.transform.position = new Vector3(0, 0, 0);
                     Plast.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 2)
                 {
                     Sklo.transform.position = new Vector3(0, 0, 0);
                     Sklo.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 3)
                 {
                     Papir.transform.position = new Vector3(0, 0, 0);
                     Papir.SetActive(true);

                 }
                 if (GameBehMed.randomSort == 4)
                 {
                     Elektro.transform.position = new Vector3(0, 0, 0);
                     Elektro.SetActive(true);
                 }
             }
         }
         Debug.Log(GameBehMed.randomSort);
     }*/
}
