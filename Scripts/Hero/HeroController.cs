using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(HeroMovement))]
// [RequireComponent(typeof(StatsManager))]
public class HeroController : MonoBehaviour
{
    // private HeroMovement heroMovement;
    protected StatsManager Status = new StatsManager();
    protected int Level = 1;
    protected int Experience = 0;
    private int maxHealth;

    protected virtual void Move()
    { 
        //Вызывается переопределённый класс в потомке HeroMovement
    }

    void Start()
    {
        EventManager.Enemy1Died += OnEnemy1Died;
        EventManager.Enemy1Attack += OnEnemy1Attack;
        maxHealth = Status.Health;
    }

    void FixedUpdate()
    {
        Move();
    }

    void OnEnemy1Died(exp)
    {
        Experience += exp;
    }

    void OnEnemy1Attack(int dmg)
    {
        if(Status.Health > 0)
        {
        Status.Health -= dmg;
        // Debug.Log("U WAS HIT, now ur HP is: " + Status.Health);
        }
    }
}
