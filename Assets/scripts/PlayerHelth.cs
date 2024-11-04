using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerHelth : MonoBehaviour
{
    #region variables
    [Header("HP")]
    [SerializeField] int MaxHP = 3;
    [SerializeField] int CurrentHP;
    private bool alive;

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

            //funcion para freezear el juego (no se como es el comando)

            //funcion para mostrar UI de muerte  (no se como hacer para q aparezca)
        }
    }
    #endregion
}
