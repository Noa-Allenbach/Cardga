using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IChar
{
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Lore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double Hp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MagicResist { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double AttackDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MagicPower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double Mana { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Cdr { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double Lf { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double Thorns { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Damage()
    {
        throw new NotImplementedException();
    }

    public void Spell(Type spellType, Type targetType)
    {
        throw new NotImplementedException();
    }

    public void TakeDamage()
    {
        throw new NotImplementedException();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
