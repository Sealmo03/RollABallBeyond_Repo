using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform followTarget;  //Referencia al obejeto que la c�mara tiene que seguir
    public Vector3 offset; // Variable para almacenar la diferencia vectorial entre c�mara y objetivo 

    // Start is called before the first frame update
    void Start()
    {
        // Vector comparativo entre dos posiciones surge de:
        // Vector del objetivo - vector original (en este caso, la c�mara)
        offset = followTarget.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        // Los movimientos de c�mara se suelen codear en el LateUpdate()
        Follower();
    }


    void Follower()
    {
        // La posici�n de la c�mara = posici�n del objeto 
        transform.position = followTarget.position - offset;
    }

}
