using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyControll : MonoBehaviour
{
    private StatsManager Status = new StatsManager();
    public Transform player;
    // private HeroController player;
    private EnemyAI enemyAI;
    // private float maxRaycastDistance = 10f; // Максимальная дальность raycast
    // private float attackRange = 1f; // Диапазон атаки

    // void Attack(int dmg)
    // {
    //     Status.Health -= dmg;
    // }

    void Start()
    {
        enemyAI = GetComponent<EnemyAI>();
        // Player = GetComponent<Transform>();
    }


    void Update()
    {
        
        // if (Status.Health <= 0)
        // {
        //     EventManager.OnEnemyDied();
        //     Destroy(gameObject);
        // }
        enemyAI.EnemyMovement(player, Status.Health, Status.MoveSpeed);

    }
}
