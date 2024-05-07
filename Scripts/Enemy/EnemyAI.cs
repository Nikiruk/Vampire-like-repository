using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyAI : MonoBehaviour
{
    public Transform player; // Ссылка на объект игрока
    private Rigidbody2D enemyRigidbody2D; // Ссылка на Rigidbody2D врага
    private float maxRaycastDistance = 10f; // Максимальная дальность raycast
    private float attackRange = 0.1f; // Диапазон атаки

    void Start()
    {
        enemyRigidbody2D = GetComponent<Rigidbody2D>(); // Получение Rigidbody2D врага
    }

    void Update()
    {
        if (player != null) // Проверка, установлен ли объект игрока
        {
            // Debug.Log("PlayerTRUE");
            // Raycast в направлении игрока
            RaycastHit2D hit = Physics2D.Raycast(transform.position, player.position, maxRaycastDistance);

            // Проверка, если raycast попал в игрока
            if (hit.collider != null && hit.collider.gameObject == player)
            {
                Debug.Log("Raycast on player");
                // Проверка, находится ли игрок в пределах диапазона атаки
                if (Vector2.Distance(transform.position, player.position) <= attackRange)
                {
                    Debug.Log("ATTACK");
                    // Атака игрока
                    // ...
                }
                else
                {
                    // Двигаться к игроку
                    Vector2 direction = (player.position - transform.position).normalized;
                    enemyRigidbody2D.AddForce(direction * enemyRigidbody2D.mass * 10f); // Приложить силу к врагу
                }
            }
        }
    }
}


