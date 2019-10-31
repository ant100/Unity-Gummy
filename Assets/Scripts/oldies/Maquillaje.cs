using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Maquillaje : MonoBehaviour

    
{
    public int puntaje = 0;

    public GameObject makeup1;
    public GameObject makeup2;
    public GameObject makeup3;

    public Button botonMakeup;

    int MaquillajeActual = 0;

   public void Start()
    {
        makeup1.SetActive(false);
        makeup2.SetActive(false);
        makeup3.SetActive(false);
    }

    public void Make()
    {

        if (MaquillajeActual == 0)
        {
            //makeup3.SetActive(false);
            //makeup2.SetActive(false);
            makeup1.SetActive(true);
            MaquillajeActual++;

            puntaje = 1;

            VariablesGlobales.score = VariablesGlobales.score + puntaje;

        }
        else if (MaquillajeActual ==1)
        {
            makeup3.SetActive(false);
            makeup1.SetActive(false);
            makeup2.SetActive(true);
            MaquillajeActual = 2;

            puntaje = 3;

            VariablesGlobales.score = VariablesGlobales.score + puntaje;
        }
        else
        {
            makeup1.SetActive(false);
            makeup2.SetActive(false);
            makeup3.SetActive(true);
            botonMakeup.enabled = false;

            puntaje = 5;

            VariablesGlobales.score = VariablesGlobales.score + puntaje;
        }

        Debug.Log(VariablesGlobales.score);

    }



    // Start is called before the first frame update
    /*  void Start()
      {

      }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
