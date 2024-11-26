using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreasureLights : MonoBehaviour
{
    public GameObject lights;
    public bool lightsOn = false;

    private void Update()
    {
        if (lightsOn == true)
        {
            lights.SetActive(true);
        }
        else
        {
            lights.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            lightsOn = true;
        }
    }
}
