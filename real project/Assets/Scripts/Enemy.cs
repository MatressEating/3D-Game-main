using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float currentHP;
    public float maxHP = 50;

    public GameObject hitbox;

    void Start()
    {
        
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
    public void Attack()
    {
        GameObject newobject = Instantiate(hitbox, transform.position, Quaternion.identity);
        Destroy(newobject, 0.3f);
    }

}
