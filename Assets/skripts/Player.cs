using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IChar
{
    // Properties for character attributes
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

    // List of spells (you can uncomment this if you want to add spells)
    // public List<Spell> Spells { get; set; }

    private void Start()
    {
        InitializePropertiesWithRandomValues();
    }

    private void InitializePropertiesWithRandomValues()
    {
        Name = "BobGlobob"; // Set a default name or generate a random name

        // Create an instance of System.Random for generating random values
        System.Random random = new System.Random();

        // Generate random values for other properties
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

        // Create a list of random spells (uncomment if you want to add spells)
        // Spells = GenerateRandomSpells();
    }

    // Method to generate random spells
    /*
    private List<Spell> GenerateRandomSpells()
    {
        List<Spell> spells = new List<Spell>();
        System.Random random = new System.Random();
        int numSpells = random.Next(1, 5);

        for (int i = 0; i < numSpells; i++)
        {
            Spell spell = new Spell();
            // Generate or assign values for the Spell properties
            // ...

            spells.Add(spell);
        }

        return spells;
    }
    */

    public void Damage()
    {
        // Implement logic to apply damage to the player character
        // You can specify the damage amount here

        // Example:
        double damageAmount = 20.0;
        Hp -= damageAmount;

        // Check if the player's HP is less than or equal to 0 and handle defeat
        if (Hp <= 0)
        {
            // Handle player defeat here (e.g., game over, show defeat screen)
        }
    }

    public void Spell(Type spellType, Type targetType)
    {
        // Implement logic to cast a spell on the target
        // The 'spellType' parameter can be used to determine which spell to cast
        // The 'targetType' parameter can be used to specify the type of target (e.g., enemy)
    }

    public void TakeDamage()
    {
        // Implement logic to handle when the player character takes damage
        // This method can be called by the enemy's attack

        // Example:
        double damageAmount = 10.0;
        Hp -= damageAmount;

        // Check if the player's HP is less than or equal to 0 and handle defeat
        if (Hp <= 0)
        {
            // Handle player defeat here (e.g., game over, show defeat screen)
        }
    }

    public int Attack(Enemy enemy)
    {
        // Implement logic for player's attack
        // Calculate and return the damage dealt
        int damageDealt = (int)(AttackDamage * (1 - enemy.Armor / 100)); // Example damage calculation
        return damageDealt;
    }

    public bool IsDefeated()
    {
        // Implement logic to check if the player is defeated
        return Hp <= 0;
    }




    // Rest of the class code...
}
