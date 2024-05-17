using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager
{
    public delegate void delegateEnemy1(int value);
    public static event delegateEnemy1 Enemy1Died;
    public static event delegateEnemy1 Enemy1Attack;
    // public static event delegateEnemy1 Enemy1Expirience;

    public static void OnEnemy1Died(int exp)
    {
        Enemy1Died?.Invoke(exp);
    }

    public static void OnEnemy1Attack(int dmg)
    {
        
        Enemy1Attack?.Invoke(dmg);
    }

    // public static void OnEnemy1Expirience(int exp)
    // {
    //     Enemy1Expirience?.Invoke(exp);
    // }
}
