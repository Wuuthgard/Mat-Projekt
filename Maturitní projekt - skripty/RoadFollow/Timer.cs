using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text timer;
    private float timeS = 0;
    public static float minuty;
    public static float sekundy;
    void Update()
    {
        if (GO_RF.PlayerAlive == true)
        {
            timeS += Time.deltaTime;
            minuty = Mathf.FloorToInt(timeS / 60);
            sekundy = timeS % 60;
            timer.text = string.Format("Časovač: {0:00} Min {1:00} Secs", minuty, sekundy);
        }
      
    }
}
