using System;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour, IChar
{
    public string Name { get; set; }
    public string Lore { get; set; }
    public double Hp { get; set; }
    public double Armor { get; set; }
    public double MagicResist { get; set; }
    public double AttackDamage { get; set; }
    public double MagicPower { get; set; }
    public double Mana { get; set; }
    public double Speed { get; set; }
    public int Cdr { get; set; }
    public double Lf { get; set; }
    public double Thorns { get; set; }
    //public List<Spell> Spells { get; set; }

    private void Start()
    {
        InitializePropertiesWithRandomValues();
    }

    private void InitializePropertiesWithRandomValues()
    {
        Name = "BobGlobob"; // Set a default name or generate a random name

        // Generate random values for other properties
        System.Random random = new System.Random();
        Hp = random.NextDouble() * 100;
        Armor = random.NextDouble() * 50;
        MagicResist = random.NextDouble() * 50;
        AttackDamage = random.NextDouble() * 100;
        MagicPower = random.NextDouble() * 100;
        Mana = random.NextDouble() * 200;
        Speed = random.NextDouble() * 10;
        Cdr = random.Next(0, 100);
        Lf = random.NextDouble() * 100;
        Thorns = random.NextDouble() * 50;

        // Create a list of random spells
      //  Spells = new List<Spell>();
        int numSpells = random.Next(1, 5); // Generate a random number of spells between 1 and 4

        /*
        for (int i = 0; i < numSpells; i++)
        {
            Spell spell = new Spell();
            // Generate or assign values for the Spell properties
            // ...

            Spells.Add(spell);
        }
        */
    }

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

    // Rest of the class code...
}
