using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Enemy : MonoBehaviour
{
    #region variables
    [Header("shooting")]
    [SerializeField] float EnemyBulletVel;
    [SerializeField] GameObject EnemyBulletPrefav;
    [SerializeField] Transform EnemyBulletSpawn;
    [SerializeField] float delay;

    [Header("Health")]
    [SerializeField] int HPEnemy;
    #endregion
    #region base methods
    private void Update()
    {
        HandleEnemyShooting();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            HandleEnemyHealth();
        }
    }
    #endregion
    #region custom methods
    protected virtual void HandleEnemyShooting()
    {
        delay =- Time.deltaTime;

        if (delay <= 0)
        {   
            GameObject bullet = Instantiate(EnemyBulletPrefav, EnemyBulletSpawn.position, EnemyBulletSpawn.rotation);
           
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = EnemyBulletSpawn.up * EnemyBulletVel; 
            }
        }
    }
    protected virtual void HandleEnemyHealth()
    {
        --HPEnemy; 
        if(HPEnemy <= 0)
        {
            Destroy(gameObject);
        }
    }
    #endregion
}
