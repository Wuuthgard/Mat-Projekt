using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HardDiff_RF : MonoBehaviour
{
    public AudioSource audioData;
    public AudioSource audioData2;
    public AudioSource audioData3;
    public Button btn;

    void Start()
    {
        btn = btn.GetComponent<Button>();
        btn.onClick.AddListener(UpdateDiff);
    }

    public void UpdateDiff()
    {
        MoveBack.speed = -15f;
        audioData2.Play();
        SceneManager.LoadScene("RoadFol");
    }

    public Image btnImage;
    Coroutine cas = null;
    IEnumerator Casovac(int time)
    {
        while (time > 0)
        {
            if (time == 3)
            {
                btnImage.color = Color.red;
            }
            else if (time == 2)
            {
                btnImage.color = Color.yellow;
                audioData3.Play();
            }
            else if (time == 1)
            {
                btnImage.color = Color.green;
                audioData.Play();
            }
            time--;
            yield return new WaitForSeconds(1);
        }
        MoveBack.speed = -15f;
        audioData.Play();
        SceneManager.LoadScene("RoadFol");
    }


    public void MouseOver()
    {
        cas = StartCoroutine(Casovac(3));

    }

    public void MouseLeft()
    {
        StopCoroutine(cas);
        btnImage.color = Color.white;
    }
}
