using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] protected GameObject[] enemyPrefabs;
    [SerializeField] protected Transform playerTransform;
    [SerializeField] private Transform parentTransform;
    [SerializeField] protected int enemyMaxCount = 10;
    [SerializeField] protected int enemyCount;

    // private HashSet<GameObject> generatedEnemies = new HashSet<GameObject>();

    void Start()
    {
        StartCoroutine(Spawn());
    }


    public void SpawnEnemies()
    {
        var positionX = Random.Range(playerTransform.position.x - 10, 10);
        var positionY = Random.Range(playerTransform.position.y - 10, 10);
        if (playerTransform != null)
        {
            if (enemyCount < enemyMaxCount)
            {
                Vector3 enemyPosition = new Vector3(positionX, positionY, 0);
                GameObject newEnemy = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], enemyPosition, Quaternion.identity);
                newEnemy.transform.SetParent(parentTransform);
                enemyCount++;
                Debug.Log("enemy spawned");
            }
        }
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            SpawnEnemies();
            yield return new WaitForSeconds(1f); // Ожидание 1 секунды
            // hitObject.SetActive(false); // Выключение объекта
            // yield return new WaitForSeconds(1); // Ожидание 1 секунды
        }
    } 
}
