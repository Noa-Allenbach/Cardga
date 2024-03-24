using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorUnit : MonoBehaviour
{

	public string unitName;
	public int unitLevel;

	public int damage;

	public int maxHP;
	public int currentHP;

	// New Values
	public string Lore;
	public double Hp;
	public double Armor;
	public double MagicResist;
	public double AttackDamage;
	public double MagicPower;
	public double Mana;
	public double Speed;
	public int Cdr;
	public double Lf;
	public double Thorns;

	public bool TakeDamage(int dmg)
	{
		currentHP -= dmg;

		if (currentHP <= 0)
			return true;
		else
			return false;
	}

	public void Heal(int amount)
	{
		currentHP += amount;
		if (currentHP > maxHP)
			currentHP = maxHP;
	}

}
