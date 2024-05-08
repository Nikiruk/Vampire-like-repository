using UnityEngine;

public class StatsManager
{
    public int Health = 100;
    public int AttackDamage = 5;
    public int MoveSpeed = 2;
    public int Experience = 0;
    public int Level = 1;

    // public virtual void MainStats()
    // {
        
    // }

    public void TakeDamage(int damage)
    {
        if (Health > 0)
            Health -= damage;            
        else
            Debug.Log("YOU ARE DEAD");
    }

    private void TakeExp(int experience)
    {
        if(experience > 0)
            Experience += experience;
        // else
        //     throw new UnityException("Experience give less than 0, to be more precise: " + experience);
    }
}
