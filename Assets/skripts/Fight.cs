using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fight : MonoBehaviour
{
    Enemy enemy;
    Player player;
    bool playerTurn;
    public TextMeshProUGUI attackButton;

    // Start is called before the first frame update
    void Start()
    {
        enemy = new Enemy();
        player = new Player();
        playerTurn = true;

        // Perform any necessary initialization for the fight
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the fight conditions are met and perform the fight logic
        if (ShouldFight())
        {
            if (playerTurn)
            {
                PlayerTurn();
            }
            else
            {
                EnemyTurn();
            }
        }
    }

    private bool ShouldFight()
    {
        // Implement the conditions for starting the fight
        // For example, check if the player and enemy are within a certain range
        // or if a certain key is pressed, etc.
        return false; // Replace with your conditions
    }

    private void PlayerTurn()
    {
        //Make a methods which displays different options to chose for the play
        attackButton.GetComponent<TextMeshProUGUI>();

        // Example:
        player.Damage();
        enemy.TakeDamage();

        // Set playerTurn to false to switch to the enemy's turn
        playerTurn = false;
    }

    private void EnemyTurn()
    {
        // Implement the enemy's turn logic here
        // For example, calculate the enemy's actions, perform attacks, etc.

        // Example:
        //enemy.Attack();
        player.TakeDamage();

        // Set playerTurn to true to switch back to the player's turn
        playerTurn = true;
    }

    public void AttackButtonPressed()
    {

    }
}
