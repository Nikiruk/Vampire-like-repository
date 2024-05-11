using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAttack : MonoBehaviour
{
    [SerializeField]private GameObject hitObject;
    private RaycastHit2D[] hits;
    private int heroAttack;


    void Start()
    {
        StartCoroutine(Hit());
    }

    IEnumerator Hit()
    {
        while (true)
        {
            Attack();
            hitObject.SetActive(true);
            yield return new WaitForSeconds(1f); // Ожидание 1 секунды

            hitObject.SetActive(false);
            yield return new WaitForSeconds(1f);
            // hitObject.SetActive(false); // Выключение объекта
            // yield return new WaitForSeconds(1); // Ожидание 1 секунды
        }
    }

    void Attack()
    {
        heroAttack = Random.Range(5, 25);
        hits = Physics2D.CircleCastAll(transform.position, 3f, transform.up, 0f, 128);

        for (int i = 0; i < hits.Length; i++)
        {
            IDamageable idamageable = hits[i].collider.gameObject.GetComponent<IDamageable>();

            if(idamageable != null)
            {
                idamageable.TakeDamage(heroAttack);
                // idamageable.ChangeColor(Color.black);
            }
        }

    }

    // void ChangeColor()
    // {
    //     Color newColor = Color.black;
    // }


}
