using System.Collections;
using TMPro;
using UnityEngine;

public class TurnBasedCombat : MonoBehaviour
{
    // Reference to player and enemy objects
    public Player player;
    public Enemy enemy;

    // UI elements
    public TextMeshProUGUI messageText;
    public TextMeshProUGUI playerHPText;
    public TextMeshProUGUI enemyHPText;
    public GameObject attackButton;

    private bool playerTurn;

    // Start is called before the first frame update
    void Start()
    {
        playerTurn = true;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if it's the player's turn
        if (playerTurn)
        {
            // Check for player input to trigger the attack
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerAttack();
            }
        }
    }

    private void PlayerAttack()
    {
        // Player attacks the enemy
        int damageDealt = player.Attack(enemy);
        enemy.TakeDamage(damageDealt);

        // Check if the enemy is defeated
        if (enemy.IsDefeated())
        {
            messageText.text = "Player wins!";
            attackButton.SetActive(false);
        }
        else
        {
            messageText.text = "Player attacks for " + damageDealt + " damage!";
            playerTurn = false;
            StartCoroutine(EnemyTurnDelay());
        }

        UpdateUI();
    }

    IEnumerator EnemyTurnDelay()
    {
        // Simulate a delay for the enemy's turn
        yield return new WaitForSeconds(1.5f);

        // Enemy's turn
        int damageDealt = enemy.Attack(player);
        player.TakeDamage();

        // Check if the player is defeated
        if (player.IsDefeated())
        {
            messageText.text = "Enemy wins!";
            attackButton.SetActive(false);
        }
        else
        {
            messageText.text = "Enemy attacks for " + damageDealt + " damage!";
            playerTurn = true;
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        playerHPText.text = "Player HP: " + player.Hp;
        enemyHPText.text = "Enemy HP: " + enemy.Hp;
    }

    public void StartBattle()
    {
        messageText.text = "Battle Start!";
        attackButton.SetActive(true);
    }
}
