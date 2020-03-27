using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Autor: Bryann Eduardo Alfaro
 * Referencia: Clase impartida
 * Clase donde se mueve con teclas un objeto
 */
public class Movement : MonoBehaviour
{
    private int velocidad_Programa = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * velocidad_Programa, 0, Input.GetAxis("Vertical") * velocidad_Programa) * Time.deltaTime, Space.World);
    }
}
