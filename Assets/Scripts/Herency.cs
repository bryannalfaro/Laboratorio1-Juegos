using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Bryann Eduardo Alfaro
 * Referencia: Clase impartida
 * Clase donde se lleva a cabo la rotacion de los objetos
 */
public class Herency : MonoBehaviour
{
    public float anguloRotacion = 45;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, anguloRotacion, 0) * Time.deltaTime);
    }
}
