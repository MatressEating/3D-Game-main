using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitboxes : MonoBehaviour
{

    public Collider[] hitbox;
    public bool atkready = false;
    public float cooldown;
    public Material newMat;
    public Material oldMat;
    public GameObject box;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        atkready = false;
        cooldown = 0.7f;
        box = GameObject.Find("Hitbox");
    }

    // Update is called once per frame
    void Update()
    {

        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
            atkready = false;
            box.GetComponent<Renderer>().material = oldMat;
        } else if (cooldown < 0)
        {
            atkready = true;
            cooldown = 0.0f;
            box.GetComponent<Renderer>().material = newMat;
        }
        if ((Input.GetKeyDown(KeyCode.G)) && (atkready == true))
        {
            LaunchAttack(hitbox[0]);
            Debug.Log("swing");
            cooldown = 0.4f;
        } else if ((Input.GetKeyDown(KeyCode.G)) && (atkready == false))
        {
            Debug.Log("calmdown");
        }
    }

    private void LaunchAttack(Collider col)
    {
        Collider[] cols = Physics.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation, LayerMask.GetMask("Hitbox"));
        foreach (Collider c in cols)
        {
            if(c.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
            {
                enemyComponent.TakeDmg(1);
            }
            rb = c.attachedRigidbody;
            rb.AddForce(transform.forward * 90, ForceMode.Impulse);

        }
    }
}
