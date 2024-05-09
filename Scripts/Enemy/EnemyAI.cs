using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyAI : MonoBehaviour
{
    // public Transform player; // Ссылка на объект игрока
    // private StatsManager Status;

    private float maxRaycastDistance = 10f; // Максимальная дальность raycast
    private float attackRange = 1f; // Диапазон атаки
    // public Transform Player;


    public void EnemyMovement(Transform player, int health, int moveSpeed)
    {
        // Player = player;
        // Debug.Log(player);
        if (player != null)
        {

            Vector2 direction = (player.position - transform.position).normalized;
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, maxRaycastDistance, 64);
            if (hit.collider != null && hit.collider.gameObject == player.gameObject)
            {
                // Debug.Log(hit.collider.gameObject);
                // Проверка, находится ли игрок в пределах диапазона атаки
                if (Vector2.Distance(transform.position, player.position) <= attackRange)
                {
                    health -= 10;
                    // Status.Health = health;
                    Debug.Log(health);
                }
                else
                {
                    // Двигаться к игроку
                    transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
                    // enemyRigidbody2D.MovePosition(new Vector2(0,0), new Vector2(1,1), 1f); // Приложить силу к врагу
                }
            }
        }

        // void Update()
        // {


        //     }

        if (health <= 0)
        {
            EventManager.OnEnemyDied();
            Destroy(gameObject);
        }
    }
}


