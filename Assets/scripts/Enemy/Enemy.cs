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
    private Coroutine shootingCoroutine;


    [Header("Health")]
    [SerializeField] int HPEnemy;
    #endregion
    #region base methods

    private void Start()
    {
        shootingCoroutine = StartCoroutine(HandleEnemyShooting());
    }

    private void Update()
    {

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
    private IEnumerator HandleEnemyShooting()
    {
        while (true)
        {   
            GameObject bullet = Instantiate(EnemyBulletPrefav, EnemyBulletSpawn.position, EnemyBulletSpawn.rotation);
            Debug.Log("dispara enemigo");

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = EnemyBulletSpawn.up * EnemyBulletVel; 
            }

            yield return new WaitForSeconds(delay);
        }


    }
    protected virtual void HandleEnemyHealth()
    {
        --HPEnemy;
        Debug.Log("daño enemigo");
        if(HPEnemy <= 0)
        {
            //funcion para mostrar UI de victoria (no se como hacer esto)
            Time.timeScale = 0f;
            Debug.Log("muere enemigo");
        }
    }
    #endregion
}
