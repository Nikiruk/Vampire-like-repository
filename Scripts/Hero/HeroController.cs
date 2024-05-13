using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(HeroMovement))]
// [RequireComponent(typeof(StatsManager))]
public class HeroController : MonoBehaviour
{
    // private HeroMovement heroMovement;
    protected StatsManager Status = new StatsManager();
    private Leveling lvl = new Leveling();
    private int maxHealth;

    protected virtual void Move()
    { 
        //Вызывается переопределённый класс в потомке HeroMovement
    }

    void Start()
    {
        // heroMovement = GetComponent<HeroMovement>();
        EventManager.Enemy1Died += OnEnemyDied;
        EventManager.Enemy1Attack += OnEnemy1Attack;
        maxHealth = Status.Health;
        // StartCoroutine(Hit());
        // EventManager.newEvent += OnEnemy1Attack;
        // Status.Health = 1000;
    }

    void FixedUpdate()
    {
        // heroMovement.MoveSetup(Status.MoveSpeed);
        Move();
        // if (Status.Health <= 0)
        // {
        //     Debug.Log("You are dead");
        //     Destroy(gameObject);
        //     Time.timeScale = 0;
        // }
        // Status.TakeDamage(5);
        // Debug.Log(Status.Health);
    }

    void OnEnemyDied()
    {
        lvl.Level += 1;
        // Debug.Log(lvl.Level);
    }

    void OnEnemy1Attack(int dmg)
    {
        if(Status.Health > 0)
        {
        Status.Health -= dmg;
        // Debug.Log("U WAS HIT, now ur HP is: " + Status.Health);
        }
    }

    // IEnumerator Hit()
    // {
    //     while (true)
    //     {
    //         hitObject.SetActive(true); // Включение объекта
    //         yield return new WaitForSeconds(1); // Ожидание 1 секунды

    //         hitObject.SetActive(false); // Выключение объекта
    //         yield return new WaitForSeconds(1); // Ожидание 1 секунды
    //     }
    // }
}
