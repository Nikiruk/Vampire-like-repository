using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;

[RequireComponent(typeof(EnemyAI))]
public class EnemyControll : MonoBehaviour, IDamageable
{
    private StatsManager Status = new StatsManager();   //генерация всех дефолтных статов, хп-атака-мувспид
    private Transform player;
    private EnemyAI enemyAI;
    private Animator animator;
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyAI = GetComponent<EnemyAI>();
        animator = GetComponentInChildren<Animator>();
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
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
}
