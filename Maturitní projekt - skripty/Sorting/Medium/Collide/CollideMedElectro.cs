using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideMedElectro : MonoBehaviour
{
    public GameObject[] Rec;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("ElektroP"))
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
}
