using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBehMed : MonoBehaviour
{
    public GameObject[] Rec;
    static public int scoreY = 0;
    static public int scoreN = 0;
    public Text scoreT;
    static public int randomSort;
    void Start()
    {
        for (int i = 0; i < Rec.Length; i++)
        {
            Rec[i].SetActive(false);
        }
        Cursor.visible = false;
        randomSort = Random.Range(1, 5);
        Rec[0].transform.position = new Vector3(0, 0, 0);
        Rec[1].transform.position = new Vector3(0, 0, 0);
        Rec[2].transform.position = new Vector3(0, 0, 0);
        Rec[3].transform.position = new Vector3(0, 0, 0);
        if (randomSort == 1)
        {
            Rec[0].SetActive(true);
        }
        if (randomSort == 2)
        {
            Rec[1].SetActive(true);
        }
        if (randomSort == 3)
        {
            Rec[2].SetActive(true);
        }
        if (randomSort == 4)
        {
            Rec[3].SetActive(true);
        }
    }

    void Update()
    {
        float xS = 0.2f * Input.GetAxis("Mouse X");
        float yS = 0.2f * Input.GetAxis("Mouse Y");
        if (TimerSortMed.timeS >= 0)
        {
            if (randomSort == 1)
            {
                Rec[0].transform.position = Rec[0].transform.position + new Vector3(xS, yS, 0);
            }
            if (randomSort == 2)
            {
                Rec[1].transform.position = Rec[1].transform.position + new Vector3(xS, yS, 0);
            }
            if (randomSort == 3)
            {
                Rec[2].transform.position = Rec[2].transform.position + new Vector3(xS, yS, 0);
            }
            if (randomSort == 4)
            {
                Rec[3].transform.position = Rec[3].transform.position + new Vector3(xS, yS, 0);
            }
        }

        if (Rec[0].transform.position.x >= 6)
        {
            Rec[0].transform.position = new Vector3(6f, Rec[0].transform.position.y, Rec[0].transform.position.z);
        }
        else if (Rec[0].transform.position.x <= -6)
        {
            Rec[0].transform.position = new Vector3(-6, Rec[0].transform.position.y, Rec[0].transform.position.z);
        }

        if (Rec[0].transform.position.y >= 3)
        {
            Rec[0].transform.position = new Vector3(Rec[0].transform.position.x, 3, Rec[0].transform.position.z);
        }
        else if (Rec[0].transform.position.y <= -4)
        {
            Rec[0].transform.position = new Vector3(Rec[0].transform.position.x, -4, Rec[0].transform.position.z);
        }

        if (Rec[2].transform.position.x >= 6)
        {
            Rec[2].transform.position = new Vector3(6f, Rec[2].transform.position.y, Rec[2].transform.position.z);
        }
        else if (Rec[2].transform.position.x <= -6)
        {
            Rec[2].transform.position = new Vector3(-6, Rec[2].transform.position.y, Rec[2].transform.position.z);
        }

        if (Rec[2].transform.position.y >= 3)
        {
            Rec[2].transform.position = new Vector3(Rec[2].transform.position.x, 3, Rec[2].transform.position.z);
        }
        else if (Rec[2].transform.position.y <= -4)
        {
            Rec[2].transform.position = new Vector3(Rec[2].transform.position.x, -4, Rec[2].transform.position.z);
        }

        if (Rec[1].transform.position.x >= 6)
        {
            Rec[1].transform.position = new Vector3(6f, Rec[1].transform.position.y, Rec[1].transform.position.z);
        }
        else if (Rec[1].transform.position.x <= -6)
        {
            Rec[1].transform.position = new Vector3(-6, Rec[1].transform.position.y, Rec[1].transform.position.z);
        }

        if (Rec[1].transform.position.y >= 3)
        {
            Rec[1].transform.position = new Vector3(Rec[1].transform.position.x, 3, Rec[1].transform.position.z);
        }
        else if (Rec[1].transform.position.y <= -4)
        {
            Rec[1].transform.position = new Vector3(Rec[1].transform.position.x, -4, Rec[1].transform.position.z);
        }

        if (Rec[3].transform.position.x >= 6)
        {
            Rec[3].transform.position = new Vector3(6f, Rec[3].transform.position.y, Rec[3].transform.position.z);
        }
        else if (Rec[3].transform.position.x <= -6)
        {
            Rec[3].transform.position = new Vector3(-6, Rec[3].transform.position.y, Rec[3].transform.position.z);
        }

        if (Rec[3].transform.position.y >= 3)
        {
            Rec[3].transform.position = new Vector3(Rec[3].transform.position.x, 3, Rec[3].transform.position.z);
        }
        else if (Rec[3].transform.position.y <= -4)
        {
            Rec[3].transform.position = new Vector3(Rec[3].transform.position.x, -4, Rec[3].transform.position.z);
        }
        scoreT.text = string.Format("CELKEM: {0} správně {1} špatně", scoreY, scoreN);
    }
}
