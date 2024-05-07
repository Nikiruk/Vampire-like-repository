using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HeroMovement : MonoBehaviour
{
    // [SerializeField] private Transform _hero;
    // private GameObject _hero;
    // private Hero hero;
    // private Hero MainHero;
    //  = new Hero("Chelik", 100, 10, 20, 10);
    private int _health = 100;
    private float _moveSpeed = 1f;
    // private int _level = 1;
    private int _experience = 0;

    // void Start()
    // {
    //     hero = GetComponent<Hero>();
    // }

    private void FixedUpdate()
    {
        MoveSetup();
    }

    private void MoveSetup()
    {
        var valueX = Input.GetAxis("Horizontal");
        var valueY = Input.GetAxis("Vertical");

        if (valueX > 0)
            transform.position += new Vector3(valueX, 0, 0) * _moveSpeed * Time.deltaTime;
        if (valueX < 0)
            transform.position += new Vector3(valueX, 0, 0) * _moveSpeed * Time.deltaTime;
        if (valueY > 0)
            transform.position += new Vector3(0, valueY, 0) * _moveSpeed * Time.deltaTime;
        if (valueY < 0)
            transform.position += new Vector3(0, valueY, 0) * _moveSpeed * Time.deltaTime;
    }

    public void DamageReceiver(int damage)
    {
        if (_health > 0)
            _health -= damage;
        else
            Debug.Log("YOU ARE DEAD");
    }

    private void GainExp(int exp)
    {
        if(exp > 0)
            _experience += exp;
        else
            throw new UnityException("Experience give less than 0, to be more precise: " + exp);
    }



}
