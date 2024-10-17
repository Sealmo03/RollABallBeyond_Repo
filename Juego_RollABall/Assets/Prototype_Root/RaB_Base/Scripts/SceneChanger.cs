using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Librer�a que permite usar m�todos de carga/descarga de escenas

public class SceneChanger : MonoBehaviour
{
   public void SceneLoader(int sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    } 

    public void ExitGame()
    {
        Application.Quit(); //Salir de la aplicaci�n, cierra el juego completamente
    }
}
