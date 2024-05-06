using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class FollowScript : MonoBehaviour
{
    public Transform targetCharacter; //Цель, за которой следует персонаж
    private NavMeshAgent agent; //Компонент NavMeshAgent для навигации

    private void Start()
    {
        // Получить компонент NavMeshAgent
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // Установить цель NavMeshAgent в позицию целевого персонажа
        if(targetCharacter != null)
            agent.SetDestination(targetCharacter.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Проверить, столкнулся ли персонаж с целевым персонажем
        if(collision.gameObject.transform == targetCharacter)
        {
            // Здесь можно добавить код для триггера столкновения
            Debug.Log("Столкновение с целевым персонажем!");
        }
    }
}





[RequireComponent(typeof(Rigidbody2D))]
public class EnemyController : MonoBehaviour
{
    // [SerializeField] private GameObject _enemyPrefab;

    private void FollowHero()
    {
        var target = GameObject.Find("MainCharacter");
        
    }
}
