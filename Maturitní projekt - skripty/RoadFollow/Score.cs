using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text score;
    void Update()
    {
        score.text = string.Format("Váše finální skóre a čas: {0}, {1:00} Min. {2:00} Sec", MoveCar.skore,Timer.minuty, Timer.sekundy);
    }
}
