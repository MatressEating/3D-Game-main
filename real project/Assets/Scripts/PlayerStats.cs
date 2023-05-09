using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public float currentHP, maxHP = 5;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    
    void Start()
    {
        currentHP = maxHP;
    }
    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < maxHP)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
            if (i < currentHP)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }

    public void TakeDmg(float damage)
    {
        currentHP -= damage;
        Debug.Log(currentHP);
        if (currentHP <= 0)
        {
            Destroy(gameObject);
            Died();
        }
    }

    public void Died()
    {
        Control.kills = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
