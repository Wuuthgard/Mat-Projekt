using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSortMed : MonoBehaviour
{
    public Text score;
    void Update()
    {
        score.text = string.Format("Vaše finální skóre je: {0} správně a {1} špatně", GameBehMed.scoreY, GameBehMed.scoreN);
    }
}
