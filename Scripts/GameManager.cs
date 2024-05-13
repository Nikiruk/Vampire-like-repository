using UnityEngine;


[RequireComponent(typeof(GridSetup))]

public class GameManager : MonoBehaviour
{
    void Update()
    {
        MapGenerate();
    }

    protected virtual void MapGenerate()
    {
        //Генерация карты в потомке GridSetup
    }
}
