using System;
using UnityEngine;

public class Enemy : MonoBehaviour, IChar
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

    // Constructor for Enemy class
    public Enemy()
    {
        // Initialize enemy properties here
        Name = "Evil Enemy"; // Set a default name or generate a random name
        Hp = 100.0; // Set default HP
        Armor = 30.0; // Set default armor
        MagicResist = 20.0; // Set default magic resist
        AttackDamage = 40.0; // Set default attack damage
        MagicPower = 10.0; // Set default magic power
        Mana = 50.0; // Set default mana
        Speed = 5.0; // Set default speed
        Cdr = 10; // Set default cooldown reduction
        Lf = 50.0; // Set default life force
        Thorns = 15.0; // Set default thorns damage
    }

    public void Damage()
    {
        // Implement logic to apply damage to the enemy
        // You can specify the damage amount here

        // Example:
        double damageAmount = 20.0;
        Hp -= damageAmount;

        // Check if the enemy's HP is less than or equal to 0 and handle defeat
        if (Hp <= 0)
        {
            // Handle enemy defeat here (e.g., remove enemy from the scene, award player points, etc.)
            Destroy(gameObject);
        }
    }

    public void Spell(Type spellType, Type targetType)
    {
        // Implement logic to cast a spell by the enemy
        // The 'spellType' parameter can be used to determine which spell to cast
        // The 'targetType' parameter can be used to specify the type of target (e.g., player character)
        // You can create an enemy-specific spell system here
    }

    public void TakeDamage()
    {
        // Implement logic to handle when the enemy takes damage
        // This method can be called by the player's attack

        // Example:
        double damageAmount = 10.0;
        Hp -= damageAmount;

        // Check if the enemy's HP is less than or equal to 0 and handle defeat
        if (Hp <= 0)
        {
            // Handle enemy defeat here (e.g., remove enemy from the scene, award player points, etc.)
            Destroy(gameObject);
        }
    }

    public int Attack(Player player)
    {
        // Implement logic for enemy's attack
        // Calculate and return the damage dealt
        int damageDealt = (int)(AttackDamage * (1 - player.Armor / 100)); // Example damage calculation
        return damageDealt;
    }

    public bool IsDefeated()
    {
        // Implement logic to check if the enemy is defeated
        return Hp <= 0;
    }

    public void TakeDamage(int damage)
    {
        // Implement logic to handle when the enemy takes damage
        // Subtract the damage from the enemy's HP
        Hp -= damage;
    }


    // Start and Update methods can be left empty for the enemy's behavior
    void Start()
    {
        // Initialize any enemy-specific behaviors or AI here
    }

    void Update()
    {
        // Implement enemy behavior or AI logic here
    }
}
