using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Rigidbody rb;
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            
            rb = c.attachedRigidbody;
            Debug.Log(rb);
            rb.AddForce(transform.forward * 9000, ForceMode.Impulse);
        }
    }



}
