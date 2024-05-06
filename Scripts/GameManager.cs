using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GridSetup))]
public class GameManager : MonoBehaviour
{
    
    private GridSetup gridSetup;
    // private HeroController heroController;
    void Start()
    {
        gridSetup = GetComponent<GridSetup>();
        // heroController = GetComponent<HeroController>();
    }

    void Update()
    {
        gridSetup.GenerateTilesAroundPlayer();
        gridSetup.DestroyFarTiles();
        // heroController.MoveSetup();
    }
}
