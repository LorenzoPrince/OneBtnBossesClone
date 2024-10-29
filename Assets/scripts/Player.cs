using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    #region Variables
    [Header("movimiento")]
    public float velocidad = 5f;
    private Vector3 direccion = Vector3.forward;

    #endregion
    #region base methods
    void Update()
    {
        transform.RotateAround(Vector3.zero, direccion, velocidad * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HandleMovement();
        }

        
    }
    #endregion
    #region custom variables
    protected virtual void HandleMovement()
    {
        direccion = -direccion;
    }

    protected virtual void handleHealth()
    {

    }

    protected virtual void handleShooting()
    {

    }
    #endregion
}
