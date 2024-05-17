using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leveling : HeroController, ILevelUp
{
    // public int Level = 1;
    // public int Experience = 0;

    public void GetExp(int exp)
    {
        Experience += exp;
    }

    // public event Action LevelUped;

    // public void LevelUP()
    // {
    //     Level++;
    //     Debug.Log("Now your lvl: " + Level);
    //     //что-то вызывает
    // }

    public void LvlUp(int lvl)
    {
        Level += lvl;
    }

    public void TakeExp(int experience)
    {
        if(experience > 0)
            Experience += experience;

    }
}
