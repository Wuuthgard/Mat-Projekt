using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideHardGlass : MonoBehaviour
{
    public GameObject[] Rec;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("SkloP"))
        {
            GameBehHard.scoreY++;
            TimerSortHard.timeS = TimerSortHard.timeS + 2;
        }
        else
        {
            GameBehHard.scoreN++;
            TimerSortHard.timeS = TimerSortHard.timeS - 1;
        }
        for (int i = 0; i < Rec.Length; i++)
        {
            Rec[i].transform.position = new Vector3(0, 0, 0);
        }
        New();
    }

    void New()
    {
        GameBehHard.randomSort = Random.Range(1, 6);
        if (GameBehHard.randomSort == 1)
        {
            Rec[0].SetActive(true);
        }
        else if (GameBehHard.randomSort == 2)
        {
            Rec[1].SetActive(true);
        }
        if (GameBehHard.randomSort == 3)
        {
            Rec[2].SetActive(true);
        }
        if (GameBehHard.randomSort == 4)
        {
            Rec[3].SetActive(true);
        }
        if (GameBehHard.randomSort == 5)
        {
            Rec[4].SetActive(true);
        }
    }
}
