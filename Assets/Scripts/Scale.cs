using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Autor: Bryann Eduardo Alfaro
 * Referencia: Clase impartida
 * Clase donde se aumenta la escala del objeto
 */
public class Scale : MonoBehaviour

{
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
            transform.localScale += Vector3.one * Time.deltaTime;
        if(Input.GetKey(KeyCode.X))
            transform.localScale -= Vector3.one * Time.deltaTime;
    }
}
