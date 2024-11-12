using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyConeAttack : MonoBehaviour 
{
    public GameObject[] objectsToActivate;  // Lista de objetos que se activar�n aleatoriamente
    public float minTime = 3f;  // Tiempo m�nimo para el temporizador (en segundos)
    public float maxTime = 7f;  // Tiempo m�ximo para el temporizador (en segundos)
    public float activeDuration = 5f;  // Tiempo durante el cual el objeto se mantiene activo


    private void Awake()
    {
        StartCoroutine((string)HandleCones());
    }

    IEnumerable HandleCones()
    {
        while (true)
        {
            // Genera un tiempo aleatorio entre minTime y maxTime
            float randomTime = Random.Range(minTime, maxTime);

            // Espera el tiempo aleatorio generado
            yield return new WaitForSeconds(randomTime);

            // Elige un objeto aleatorio de la lista
            int randomIndex = Random.Range(0, objectsToActivate.Length);
            GameObject selectedObject = objectsToActivate[randomIndex];

            // Activa el objeto seleccionado
            selectedObject.SetActive(true);

            // Espera el tiempo durante el cual el objeto estar� activo
            yield return new WaitForSeconds(activeDuration);

            // Desactiva el objeto despu�s del tiempo de duraci�n
            selectedObject.SetActive(false);
        }
    }
}
