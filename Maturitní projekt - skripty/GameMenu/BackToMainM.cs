using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainM : MonoBehaviour
{
    public AudioSource audioData;
    public AudioSource audioData2;
    public AudioSource audioData3;
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
        audioData.Play();
        SceneManager.LoadScene("Main Menu");
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

    public void MainMenu()
    {
        audioData2.Play();
        SceneManager.LoadScene("Main Menu");
    }
}
