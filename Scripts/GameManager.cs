using System.Collections;
using UnityEngine;


[RequireComponent(typeof(GridSetup))]

public class GameManager : MonoBehaviour
{
    // private Transform playerTransform;

    // void Start()
    // {
        // playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        // StartCoroutine(Spawn());
        // EventManager.Enemy1Died += OnEnemyDied;
    // }

    void Update()
    {
        MapGenerate();
        // EnemySpawning();
    }

    protected virtual void MapGenerate()
    {
        //Генерация карты из потомка GridSetup
    }

    // protected virtual void EnemySpawning()
    // {
    //     //Генерация врагов из потомка EnemySpawn
    // }

    // private IEnumerator Spawn()
    // {
    //     while (true)
    //     {
    //         EnemySpawning();
    //         yield return new WaitForSeconds(1f); // Ожидание 1 секунды
    //     }
    // } 
}
