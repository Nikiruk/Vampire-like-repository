using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyAI : MonoBehaviour
{
    public Transform player; // Ссылка на объект игрока
    // private Rigidbody2D enemyRigidbody2D; // Ссылка на Rigidbody2D врага
    // private Transform enemyPosition;
    // private Vector3 pos;
    // private Vector2 newPosition;
    private float maxRaycastDistance = 10f; // Максимальная дальность raycast
    private float attackRange = 1f; // Диапазон атаки

    void Start()
    {
        // enemyPosition = GetComponent<Transform>(); // Получение Rigidbody2D врага
    }

    void Update()
    {
        
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
                    // Debug.Log("ATTACK");
                    // Атака игрока
                    // ...
                }
                else
                {
                    // Двигаться к игроку
                    transform.position = Vector2.MoveTowards(transform.position, player.position, 1f * Time.deltaTime);
                    // enemyRigidbody2D.MovePosition(new Vector2(0,0), new Vector2(1,1), 1f); // Приложить силу к врагу
                }
            }
                
        }
    }
}


