using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;

[RequireComponent(typeof(EnemyAI))]
public class EnemyControll : MonoBehaviour, IDamageable
{
    private StatsManager Status = new StatsManager();
    private Transform player;
    // private HeroController player;
    private EnemyAI enemyAI;
    private Animator animator;
    private TextMeshProUGUI textMeshPro;
    // private float maxRaycastDistance = 10f; // Максимальная дальность raycast
    // private float attackRange = 1f; // Диапазон атаки

    // void Attack(int dmg)
    // {
    //     Status.Health -= dmg;
    // }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyAI = GetComponent<EnemyAI>();
        animator = GetComponentInChildren<Animator>();
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        // Player = GetComponent<Transform>();
    }


    void Update()
    {
        // Debug.Log(textMeshPro);
        enemyAI.EnemyMovement(player, Status.MoveSpeed);

        if (Status.Health <= 0)
        {
            EventManager.OnEnemy1Died();
            Destroy(gameObject);
        }

    }

    public void TakeDamage(int dmg)
    {
        if (Status.Health > 0)
            Status.Health -= dmg;
        Debug.Log("Enemy was hited, his health now: " + Status.Health);
        if (animator != null)
        {

            textMeshPro.text = Convert.ToString("-" + dmg);
            animator.Play("DamageFly");


        }
    }

    // public void GiveDamage(int dmg)
    // {
    //     throw new NotImplementedException();
    // }
}
