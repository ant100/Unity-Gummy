using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cabello : MonoBehaviour
{
    public int puntaje = 0;

    public GameObject largo1;
    public GameObject largo2;
    public GameObject largo3;

    public Button botonCortar;

    int largoActual = 3;
    public void Cortar()
    {

        if (largoActual == 3)
        {
            //largo2.SetActive(false);
            largo3.SetActive(false);
            largoActual = 2;
            puntaje = 1;

            VariablesGlobales.score = VariablesGlobales.score + puntaje;
        }
        else if (largoActual == 2)
        {
            largo2.SetActive(false);
            largoActual = 1;
            botonCortar.enabled = false;
            puntaje = 3;

            VariablesGlobales.score = VariablesGlobales.score + puntaje;
        }

        //si algo esta activo 

        /*if largo 3
         * apagar largo 3
         * largoACtual=2
         * 
         * if largo 2
         * apagar largo 2
         * inabilita el boton
         * 
         * 
         */

        Debug.Log(VariablesGlobales.score);
    }
}
