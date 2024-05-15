using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] protected GameObject[] enemyPrefabs;
    [SerializeField] private Transform parentTransform;
    [SerializeField] protected int enemyMaxCount = 10;
    [SerializeField] protected int enemyCount;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(Spawn());
        EventManager.Enemy1Died += OnEnemyDied;
    }


    public void SpawnEnemies()
    {
        var positionX = Random.Range(playerTransform.position.x - 10, playerTransform.position.x + 10);
        var positionY = Random.Range(playerTransform.position.y - 10, playerTransform.position.y + 10);
        if (playerTransform != null)
        {
            if (enemyCount < enemyMaxCount)
            {
                Vector3 enemyPosition = new Vector3(positionX, positionY, 0);
                GameObject newEnemy = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], enemyPosition, Quaternion.identity);
                newEnemy.transform.SetParent(parentTransform);
                enemyCount++;
                Debug.Log("enemy spawned" + playerTransform.position);
            }
        }
    }

    void OnEnemyDied()
    {
        enemyCount--;
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            SpawnEnemies();
            yield return new WaitForSeconds(1f); // Ожидание 1 секунды
        }
    } 
}
