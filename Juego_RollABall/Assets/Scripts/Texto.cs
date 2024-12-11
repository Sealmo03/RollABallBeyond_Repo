using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto : MonoBehaviour
{
    public GameObject panelInstrucciones;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(ApagarPanel), 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ApagarPanel()
    {
        panelInstrucciones.SetActive(false);
    }

}
