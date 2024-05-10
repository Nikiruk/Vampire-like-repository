using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyAI))]
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
        enemyAI.EnemyMovement(player, Status.MoveSpeed);

        if (Status.Health <= 0)
        {
            EventManager.OnEnemy1Died();
            Destroy(gameObject);
        }

    }
}
