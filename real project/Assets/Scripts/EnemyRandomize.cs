using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomize : MonoBehaviour
{
    public EnemyAI AI;
    public Enemy Stats;
    delegate void ChooseMod();
    void CreateList()
    {
        List<ChooseMod> chooseMods = new List<ChooseMod>();
        chooseMods.Add(Test1);
        chooseMods.Add(Test2);
        Debug.Log("made");

        chooseMods[Random.Range(0, 2)]();
        chooseMods[Random.Range(0, 2)]();
        chooseMods[Random.Range(0, 2)]();
    }

    void Test1()
    {
        Stats.maxHP = Random.Range(5, 11);
        Stats.currentHP = Stats.maxHP;
        
        Debug.Log("1");
    }
    void Test2()
    {
        Debug.Log("NUMBAH 222222222");
    }
    
 

    void Start()
    {
        CreateList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
