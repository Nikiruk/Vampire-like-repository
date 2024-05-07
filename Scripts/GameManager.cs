using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using Unity.AI.Navigation;

[RequireComponent(typeof(GridSetup))]

public class GameManager : MonoBehaviour
{
    
    private GridSetup gridSetup;
    // private NavMeshSurface meshBuilder;
    // private HeroController heroController;
    void Start()
    {
        gridSetup = GetComponent<GridSetup>();
        // meshBuilder = GetComponent<NavMeshSurface>();
        // heroController = GetComponent<HeroController>();
    }

    void Update()
    {
        gridSetup.GenerateTilesAroundPlayer();
        gridSetup.DestroyFarTiles();
        // meshBuilder.BuildNavMesh();
        // heroController.MoveSetup();
    }
}
