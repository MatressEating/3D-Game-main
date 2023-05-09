using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Quit()
    {
        Debug.Log("qyuit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Rerun()
    {
        Debug.Log("runnit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Control.kills = 0;
        Control.runs = 0;
    }
}
