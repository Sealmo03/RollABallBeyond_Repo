using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Librerias par poder referenciar elementos de la IU
using TMPro; // Librería para poder referenciar elementos de Text Mesh ProS

public class PlayerInteraction : MonoBehaviour
{

    [Header("UI References")]
    public TMP_Text pointsText; // Ref al texto de UI que quiero que cambie dinámicamente según los puntos del player

    [Header("SceneManager")]
    public SceneChanger sceneManagerScript;
    public int sceneToLoad;

    [Header("Point System Parameters")]
    //Variables para definir los puntos del jugador
    public int currentPoints;
    public int winPoints;
    public GameObject winGoal;

    [Header("Respawn Parameters")]
    public Transform respawnPoint;
    public float respawnFallLimit;

    private void Update()
    {
        if (currentPoints < 0) { currentPoints = 0; }
        if (transform.position.y < respawnFallLimit){ Respawn(); }
        if (currentPoints >= winPoints) { winGoal.SetActive(true); }
        UIUpdater();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            currentPoints += 1;
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("PickDown"))
        {
            currentPoints -= 1;
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            WinningCall();
            other.gameObject.SetActive(false);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = respawnPoint.position;
    }

    void UIUpdater()
    {
        pointsText.text = "Points: " + currentPoints.ToString() + "/" + winPoints.ToString();

    }

    void WinningCall()
    {
        //Acción del cambio de escena
        sceneManagerScript.SceneLoader(sceneToLoad);
    }
}
