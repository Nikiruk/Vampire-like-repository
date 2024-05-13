using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSetup : GameManager
{
    [SerializeField] private GameObject[] tilePrefabs;
    // [SerializeField] protected GameObject[] enemyPrefabs;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform parentTransform;
    [SerializeField] private float tileRange = 5f; // Установите диапазон, в котором тайлы будут генерироваться вокруг игрока
    [SerializeField] private float destroyDistance = 10f; // Установите дистанцию, при превышении которой тайлы будут уничтожаться
    // [SerializeField] private int countDifferenceTiles;
    // [SerializeField] protected int enemyMaxCount;
    // protected int enemyCount = 0;

    private HashSet<Vector3> generatedTiles = new HashSet<Vector3>();

    protected override void MapGenerate()
    {
        GenerateTilesAroundPlayer();
        DestroyFarTiles();
    }

    public void GenerateTilesAroundPlayer()
    {
        if (playerTransform != null)
        {
            int roundX = Mathf.RoundToInt(playerTransform.position.x);
            int roundY = Mathf.RoundToInt(playerTransform.position.y);

            for (float x = roundX - tileRange; x < roundX + tileRange; x++)
            {
                for (float y = roundY - tileRange; y < roundY + tileRange; y++)
                {
                    Vector3 tilePosition = new Vector3(x, y, 0);
                    if (!generatedTiles.Contains(tilePosition))
                    {
                        GameObject newTile = Instantiate(tilePrefabs[Random.Range(0, tilePrefabs.Length)], tilePosition, Quaternion.identity);
                        newTile.transform.SetParent(parentTransform);
                        newTile.name = tilePosition.ToString(); // Устанавливаем имя тайла, чтобы легко найти его потом
                        generatedTiles.Add(tilePosition);
                    }
                }
            }
        }
    }

    public void DestroyFarTiles()
    {
        if (playerTransform != null)
        {
            foreach (Vector3 tilePosition in new List<Vector3>(generatedTiles))
            {
                if (Vector3.Distance(playerTransform.position, tilePosition) > destroyDistance)
                {
                    GameObject tileToDestroy = GameObject.Find(tilePosition.ToString());
                    if (tileToDestroy != null)
                    {
                        Destroy(tileToDestroy);
                        generatedTiles.Remove(tilePosition);
                    }
                }
            }
        }
    }
}
