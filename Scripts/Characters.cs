using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters
{
    private string _name;
    private int _health;
    private int _attackDamage;
    private int _attackSpeed;
    private int _moveSpeed;

    public Characters (string name, int HP, int Damage, int MoveSpeed)
    {
        _name = name;
        _health = HP;
        _attackDamage = Damage;
        // _attackSpeed = AttackSpeed;
        _moveSpeed = MoveSpeed;
    }
}

public class Enemy
{
    private Characters enemy = new Characters("vasa", 100, 5, 2);
}
