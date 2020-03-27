using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Autor: Bryann Eduardo Alfaro
 * Referencia: Clase impartida
 * Clase donde se oscila un objeto
 */
public class Oscilation : MonoBehaviour { 

    private Vector3 posicionInicial;
    private int velocidad_Programa = 2;
    
    void Start()
    {
    posicionInicial = transform.localPosition;
}

    void Update()
    {
        transform.localPosition = posicionInicial + new Vector3(0, Mathf.Sin(Time.time * velocidad_Programa), 0);
    }
}
