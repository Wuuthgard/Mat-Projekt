using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GO : MonoBehaviour
{
    public static bool PlayerAlive = true;
    private Text gO;
    // Start is called before the first frame update
    void Start()
    {
        gO = GetComponent<Text>();
        gO.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerAlive == false)
        {
            Coroutine cas = null;
            cas = StartCoroutine(Casovac(3));
            IEnumerator Casovac(int time)
            {
               while (time > 0)
               {
                   gO.enabled = true;
                   if (time == 3)
                   {
                        gO.text = string.Format("Načítá se scéna s prohrou.");
                   }
                   else if (time == 2)
                   {
                        gO.text = string.Format("Načítá se scéna s prohrou..");
                   }
                   else if (time == 1)
                   {
                        gO.text = string.Format("Načítá se scéna s prohrou...");
                   }
                   time--;
                   yield return new WaitForSeconds(1);
               }
                EnemyAI.wave = 1;
                Cursor.visible = true;
                SceneManager.LoadScene("SI_GameOver");
            }
        }
    }

}
