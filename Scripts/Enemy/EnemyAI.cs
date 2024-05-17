using UnityEditor.PackageManager;
using UnityEngine;

public class EnemyAI : EnemyController
{
    // private float maxRaycastDistance = 100f; // Максимальная дальность raycast
    // private float attackRange = 1f; // Диапазон атаки
    // private LayerMask playerLayerMask; // Слой, на котором находится игрок

    // private void Start()
    // {
    //     // Установите слой игрока
        
    // }

    protected override void EnemyMoving()
    {
        EnemyMovement();
    }

// Transform player = EnemyControll.player, float moveSpeed
    private void EnemyMovement()
    {
        // Debug.Log("helloMF" + player);
        // if (player == null)
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 100f, 64);
            
            // if (hit.collider == null)
            //     Debug.Log("HIT COLIDER IS NULL");


            
            if (hit.collider != null && hit.collider.gameObject == player.gameObject)
            {
                float distanceToPlayer = Vector2.Distance(transform.position, player.position);
                
                if (distanceToPlayer <= 1f)
                {
                    EventManager.OnEnemy1Attack(10);
                }
                else
                {
                    transform.position = Vector2.MoveTowards(transform.position, player.position, Status.MoveSpeed * Time.deltaTime);
                }
            }
            else
            {
                // Если Raycast не находит игрока, продолжайте движение в последнем направлении к игроку
                transform.position = Vector2.MoveTowards(transform.position, player.position, Status.MoveSpeed * Time.deltaTime);
            }
        }
    }
}



