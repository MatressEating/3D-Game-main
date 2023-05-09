using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCheck : MonoBehaviour
{
    public Text killCounter;
    public Text runCounter;



    // Update is called once per frame
    void Update()
    {
        killCounter.text = "Kills: " + Control.kills.ToString();
        runCounter.text = "Runs: " + Control.runs.ToString();

    }
}
