using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void EmpezarNivel(string n)
    {
        SceneManager.LoadScene(n);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Se cerro el juego");
    }

    public void opciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    
}
