using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCheckBest : MonoBehaviour
{
    public Text bestkillCounter;
    public Text bestrunCounter;



    // Update is called once per frame
    void Update()
    {
        bestkillCounter.text = "Most Kills: " + Control.bestkills.ToString();
        bestrunCounter.text = "Most Runs: " + Control.bestruns.ToString();
    }
}
