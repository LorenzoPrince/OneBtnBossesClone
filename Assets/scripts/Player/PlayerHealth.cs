using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

[RequireComponent(typeof(Player))]
public class PlayerHealth : MonoBehaviour
{
    #region variables
    [Header("HP")]
    [SerializeField] int MaxHP = 3;
    [SerializeField] int CurrentHP;
    private bool alive;
    [SerializeField] GameObject deathPanel;
    #endregion
    #region base methods
    void Awake()
    {
        alive = true;
        CurrentHP = MaxHP;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (alive == true && collision.CompareTag("Enemy_Bullet"))
        {
            CurrentHP--;
            handleHealth();
        }
    }


    #endregion
    #region custom methods
    protected virtual void handleHealth()
    {
        if(CurrentHP <= 0) 
        { 
            alive = false;
            Time.timeScale = 0f;
            deathPanel.SetActive(true);
        }
    }
    #endregion
}
