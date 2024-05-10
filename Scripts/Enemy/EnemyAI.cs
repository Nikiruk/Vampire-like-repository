using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyAI : MonoBehaviour
{
    private float maxRaycastDistance = 10f; // Максимальная дальность raycast
    private float attackRange = 1f; // Диапазон атаки

    public void EnemyMovement(Transform player, int moveSpeed)
    {
        if (player != null)
        {

            Vector2 direction = (player.position - transform.position).normalized;
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, maxRaycastDistance, 64);
            if (hit.collider != null && hit.collider.gameObject == player.gameObject)
            {
                if (Vector2.Distance(transform.position, player.position) <= attackRange)
                {
                    EventManager.OnEnemy1Attack(10);
                }
                else
                {
                    transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);   
                }
            }
        }
    }
}


