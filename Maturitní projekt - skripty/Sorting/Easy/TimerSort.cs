using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerSort : MonoBehaviour
{
    public Text timerS;
    public Text end;
    public static float timeS = 30;
    void Update()
    {
        if(timeS>=0)
        {
            timeS -= Time.deltaTime;
            timerS.text = string.Format("ZBÝVAJÍCÍ ČAS: {0:00}", timeS);
        }
        else if(timeS<=0)
        {
            end.enabled = true;
            Coroutine cas = null;
            cas = StartCoroutine(Casovac(3));
            IEnumerator Casovac(int time)
            {
                while (time > 0)
                {
                    if (time == 3)
                    {
                        end.text = string.Format("ČAS UPLYNUL, NAČÍTÁM KONEČNÉ SKÓRE.");
                    }
                    else if (time == 2)
                    {
                        end.text = string.Format("ČAS UPLYNUL, NAČÍTÁM KONEČNÉ SKÓRE..");
                    }
                    else if (time == 1)
                    {
                        end.text = string.Format("ČAS UPLYNUL, NAČÍTÁM KONEČNÉ SKÓRE...");
                    }
                    time--;
                    yield return new WaitForSeconds(1);
                }
                Cursor.visible = true;
                SceneManager.LoadScene("SrtEnd_easy");
            }
        }
    }
}
