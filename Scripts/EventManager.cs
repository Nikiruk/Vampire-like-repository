using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action Enemy1Died;

    public static void OnEnemyDied()
    {
        Enemy1Died?.Invoke();
    }
}
