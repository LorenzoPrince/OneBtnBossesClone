using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class EnemyAttacks : MonoBehaviour
{
    [Header("shooting")]
    [SerializeField] float EnemyBulletVel;
    [SerializeField] GameObject EnemyBulletPrefab;
    [SerializeField] List <Transform> EnemyBulletSpawn;
    [SerializeField] float delay;

    private Coroutine shootingCoroutine;

    private void Awake()
    {
        
    }

}
