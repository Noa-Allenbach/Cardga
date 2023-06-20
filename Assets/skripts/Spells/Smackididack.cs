using Assets.skripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smackididack : MonoBehaviour, ISpell
{
    public int Cd { get; set; }
    public int Mana { get; set; }
    public int Scaling { get; set; }

    public int damageNumber { get; set; }

    public void Cast()
    {
       
    }

    private void Initilize()
    {
        Cd = 2;
        Mana = 20;
        Scaling = 20;
        damageNumber = 30;
    }

    // Start is called before the first frame update
    void Start()
    {
        Initilize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
