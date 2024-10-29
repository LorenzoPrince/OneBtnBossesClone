using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{
    #region variables
    [SerializeField] float timer;

    #endregion

    #region base methods
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        HandleDestroy();
    }

    #endregion

    #region custom methods
    protected virtual void HandleDestroy()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
    #endregion
}
