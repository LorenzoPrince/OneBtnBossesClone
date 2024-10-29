using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    //#region Variables
    //[Header("movimiento")]
    //[SerializeField] float movSpeed = 5f;
    //[SerializeField] Rigidbody2D rb;

    //Vector2 movement;
    //#endregion
    //#region base methods
    //void Update()
    //{
    //    // Input
    //    HandleMovement();
    //}

    //private void FixedUpdate()
    //{
    //    // Movement
    //    rb.MovePosition(rb.position + movement * movSpeed * Time.fixedDeltaTime);
    //}
    //#endregion
    //#region custom variables
    //protected virtual void HandleMovement()
    //{
    //    movement.x = Input.GetAxisRaw("Horizontal");
    //    movement.y = Input.GetAxisRaw("Vertical");
    //}

    //protected virtual void handleHealth()
    //{

    //}

    //protected virtual void handleShooting()
    //{

    //}
    //#endregion

    public float velocidad = 5f; // Velocidad de movimiento
    private Vector3 direccion = Vector3.forward; // Dirección inicial

    void Update()
    {
        // Movimiento circular
        transform.RotateAround(Vector3.zero, direccion, velocidad * Time.deltaTime);

        // Cambio de dirección con la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiarDireccion();
        }
    }

    void CambiarDireccion()
    {
        // Cambia la dirección (puedes cambiarlo según tus necesidades)
        direccion = -direccion;
    }
}
