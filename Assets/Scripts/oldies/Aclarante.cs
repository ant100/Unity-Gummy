using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aclarante : MonoBehaviour
{
    public int puntaje = 0;

    public GameObject Aclarante1;
    public GameObject Aclarante2;
    public GameObject Aclarante3;

    public Button BtnAclarante;

    int AclaranteActual = 0;

    // Start is called before the first frame update
    void Start()
    {
        Aclarante1.SetActive(false);
        Aclarante2.SetActive(false);
        Aclarante3.SetActive(false);

    }

    public void Aclarar()
    {
        if (AclaranteActual == 0)
        {
            //makeup3.SetActive(false);
            //makeup2.SetActive(false);
            Aclarante1.SetActive(true);
            AclaranteActual++;

            puntaje = 1;

            VariablesGlobales.score = VariablesGlobales.score + puntaje;


        }
        else if (AclaranteActual == 1)
        {
            Aclarante3.SetActive(false);
            Aclarante1.SetActive(false);
            Aclarante2.SetActive(true);
            AclaranteActual = 2;

            puntaje = 3;

            VariablesGlobales.score = VariablesGlobales.score + puntaje;

        }
        else
        {
            Aclarante1.SetActive(false);
            Aclarante2.SetActive(false);
            Aclarante3.SetActive(true);
            BtnAclarante.enabled = false;

            puntaje = 5;

            VariablesGlobales.score = VariablesGlobales.score + puntaje;

        }

        Debug.Log(VariablesGlobales.score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
