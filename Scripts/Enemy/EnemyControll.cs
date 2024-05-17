using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;

// [RequireComponent(typeof(EnemyAI))]
public class EnemyController : MonoBehaviour, IDamageable
{
    protected StatsManager Status = new StatsManager();   //генерация всех дефолтных статов, хп-атака-мувспид
    protected Transform player;
    // protected LayerMask playerLayerMask = LayerMask.GetMask("Player");
    // private EnemyAI enemyAI;
    private Animator animator;
    private TextMeshProUGUI textMeshPro;
    private int Experience = 0;
    

    void Start()
    {
        // playerLayerMask = LayerMask.GetMask("Player");
        player = GameObject.FindGameObjectWithTag("Player").transform;
        // enemyAI = GetComponent<EnemyAI>();
        animator = GetComponentInChildren<Animator>();
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
    }


    void Update()
    {
        // enemyAI.EnemyMovement(player, Status.MoveSpeed);
        EnemyMoving();
        if (Status.Health <= 0)
        {
            EventManager.OnEnemy1Died(Experience);
            Destroy(gameObject);
        }

    }

    protected virtual void EnemyMoving()
    {
        //вызов метода из потомка
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
