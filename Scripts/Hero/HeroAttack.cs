using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor.PackageManager;
using UnityEngine;

public class HeroAttack : HeroController
{
    [SerializeField]private GameObject hitObject;
    private RaycastHit2D[] hits;


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
        }
    }

    void Attack()
    {
        hits = Physics2D.CircleCastAll(hitObject.transform.position, 0.5f, transform.up, 0f, 128);

        for (int i = 0; i < hits.Length; i++)
        {
            IDamageable idamageable = hits[i].collider.gameObject.GetComponent<IDamageable>();

            if(idamageable != null)
            {
                idamageable.TakeDamage(Status.AttackDamage + Random.Range(0, 5));
            }
        }

    }
}
