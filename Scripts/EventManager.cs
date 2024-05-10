using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager
{
    public delegate void delegateEnemy1(int value);
    public static event Action Enemy1Died;
    public static event delegateEnemy1 Enemy1Attack;
    public static event delegateEnemy1 Enemy1Expirience;

    // public UnityEvent newEvent;

    public static void OnEnemy1Died()
    {
        Enemy1Died?.Invoke();
    }

    public static void OnEnemy1Attack(int dmg)
    {
        
        Enemy1Attack?.Invoke(dmg);
    }

    public static void OnEnemy1Expirience(int exp)
    {
        Enemy1Expirience?.Invoke(exp);
    }
}
