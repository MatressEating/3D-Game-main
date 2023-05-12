using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapHitbox : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (c.gameObject.TryGetComponent<PlayerStats>(out PlayerStats playerComponent))
            {
                playerComponent.TakeDmg(1);
            }
        }
    }
}
