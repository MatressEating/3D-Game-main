using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameStart()
    {
        Debug.Log("start game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Control.kills = 0;
        Control.runs = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("exit game");
    }
}
