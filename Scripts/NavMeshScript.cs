using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class NavMeshScript : MonoBehaviour
{
    public NavMeshSurface navMesh;

    void StartBakeMesh()
    {
        navMesh.BuildNavMesh();
    }
}
