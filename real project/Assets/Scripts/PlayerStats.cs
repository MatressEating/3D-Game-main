using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float currentHP, maxHP = 50;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDmg(float damage)
    {
        currentHP -= damage;
        Debug.Log(currentHP);
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

}
