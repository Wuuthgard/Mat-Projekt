using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideGlass : MonoBehaviour
{
    public GameObject[] Rec;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        if (collision.gameObject.CompareTag("SkloP"))
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
}
