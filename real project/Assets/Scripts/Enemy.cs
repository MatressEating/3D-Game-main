using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float currentHP;
    public float maxHP = 5 + Control.runs;

    public GameObject hitbox;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public new Transform camera;

    //public KillCheck player;

    void Start()
    {
        currentHP = maxHP;
        //player = GameObject.Find("KillCount").GetComponent<KillCheck>();
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

    public void LateUpdate()
    {
        transform.LookAt(camera);
    }

    public void TakeDmg(float damage)
    {   
        currentHP -= damage;
        if (currentHP <= 0)
        {
            Destroy(gameObject);
            Control.kills++;
        }
    }
    public void Attack()
    {
        GameObject newobject = Instantiate(hitbox, transform.position, Quaternion.identity);
        Destroy(newobject, 0.3f);
    }

    //pasted
    

    

}
