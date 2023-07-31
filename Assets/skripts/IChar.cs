using System;

using System.Collections.Generic;

public interface IChar
{
    string Name { get; set; }
    string Lore { get; set; }
    double Hp { get; set; }
    double Armor { get; set; }
    double MagicResist { get; set; }
    double AttackDamage { get; set; }
    double MagicPower { get; set; }
    double Mana { get; set; }
    double Speed { get; set; }
    int Cdr { get; set; }
    double Lf { get; set; }
    double Thorns { get; set; }
    //List<Spell> Spells { get; set; }

    void Damage();
    void Spell(Type spellType, Type targetType);
    void TakeDamage();
}

