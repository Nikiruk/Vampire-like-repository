using UnityEngine;


[RequireComponent(typeof(GridSetup))]

public class GameManager : MonoBehaviour
{
    
    // private GridSetup gridSetup;
    // private NavMeshSurface meshBuilder;
    // private HeroController heroController;
    void Start()
    {
        // gridSetup = GetComponent<GridSetup>();
        // meshBuilder = GetComponent<NavMeshSurface>();
        // heroController = GetComponent<HeroController>();
    }

    void Update()
    {
        MapGenerate();
        // gridSetup.GenerateTilesAroundPlayer();
        // gridSetup.DestroyFarTiles();
        // meshBuilder.BuildNavMesh();
        // heroController.MoveSetup();
    }

    protected virtual void MapGenerate()
    {
        //Генерация карты в потомке GridSetup
    }
}
