using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float currentHP, maxHP;

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
