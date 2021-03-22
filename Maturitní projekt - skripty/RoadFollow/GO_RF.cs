using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GO_RF : MonoBehaviour
{
    public static bool PlayerAlive = true;
    public Text gO;
    void Update()
    {
        if (PlayerAlive == false)
        {
            gO.enabled = true;
            Coroutine cas = null;
            cas = StartCoroutine(Casovac(3));
            IEnumerator Casovac(int time)
            {
                while (time > 0)
                {
                    if (time == 3)
                    {
                        gO.text = string.Format("Načítá se scéna s body.");
                    }
                    else if (time == 2)
                    {
                        gO.text = string.Format("Načítá se scéna s body..");
                    }
                    else if (time == 1)
                    {
                        gO.text = string.Format("Načítá se scéna s body...");
                    }
                    time--;
                    yield return new WaitForSeconds(1);
                }
                Cursor.visible = true;
                SceneManager.LoadScene("RF_GameOver");
            }
        }
    }
}
