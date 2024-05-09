using System;
using UnityEngine;

public class StatsManager
{
    public int Health = 100;
    public int AttackDamage = 5;
    public int MoveSpeed = 2;
    // public int Experience = 0;
    // public int Level = 1;
    public string Type = "enemy";
    // public event Action Damaged;

    // public virtual void MainStats()
    // {
        
    // }

    // public delegate void DelegateDamage(int dmg);

    

    public void TakeDamage(int damage)
    {
        if (Health > 0)
            Health -= damage;            
        else
            Debug.Log("YOU ARE DEAD");
    }

    

    
}
