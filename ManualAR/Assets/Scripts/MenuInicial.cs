using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void Camara()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Manuales()
    {
        SceneManager.LoadScene(2);
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void LegoBatman()
    {
        SceneManager.LoadScene(3);
    }
}
