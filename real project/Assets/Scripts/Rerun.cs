using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rerun : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("reset! ! !");
            Control.runs++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}
