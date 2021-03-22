using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    private Transform enemy;
    public AudioSource audioData;
    public static float speed = 0;
    public Text winTxt;
    public Text backTxt;
    public static float wave = 1;
    // Start is called before the first frame update
    void Start()
    {
        winTxt.enabled = false;
        InvokeRepeating("Move", 0.1f, 0.2f);
        enemy = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Move()
    {
        enemy.position += Vector3.right * speed;
        foreach (Transform enemyy in enemy)
        {
            if (GO.PlayerAlive == true)
            {
                if (enemyy.position.x <= -7 || enemyy.position.x >= 7)
                {
                    audioData.Play();
                    speed = -speed;
                    enemy.position += Vector3.down * 0.5f;
                    return;
                }
            }
            else
            {
                speed = 0;
            }
            if (enemyy.position.y <= -3)
            {
                GO.PlayerAlive = false;
            }
        }
    }

  void Update()
    {
        Coroutine cas = null;
        if (transform.childCount == 0)
        {
            cas = StartCoroutine(Casovac(3));
            IEnumerator Casovac(int time)
            {
                while (time > 0)
                {
                    winTxt.enabled = true;
                    if (time == 3)
                    {
                        winTxt.text = string.Format("Načítá se výherní scéna.");
                    }
                    else if (time == 2)
                    {
                        winTxt.text = string.Format("Načítá se výherní scéna..");
                    }
                    else if (time == 1)
                    {
                        winTxt.text = string.Format("Načítá se výherní scéna...");
                    }
                    time--;
                    yield return new WaitForSeconds(1);
                }
                Cursor.visible = true;
                SceneManager.LoadScene("SI_Win");
            }
            
        }
    }
}
