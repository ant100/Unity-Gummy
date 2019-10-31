using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

public class Final : MonoBehaviour
{

    //public  Text textScore;
    // public Text winText;
    public GameObject fondo1;
    public GameObject fondo2;
    public GameObject fondo3;
    public Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        fondo3.SetActive(false);
        fondo2.SetActive(false);
        fondo1.SetActive(false);
        //el score solo se actualiza una vez
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (VariablesGlobales.score < 5)
        {
            fondo1.SetActive(true);
        }
        else if (VariablesGlobales.score >= 5 && VariablesGlobales.score <= 9)
        {
            fondo2.SetActive(true);
            fondo1.SetActive(false);

        }
        else 
        {
            fondo1.SetActive(false);
            fondo2.SetActive(false);
            fondo3.SetActive(true);
        }
        
    }
    //llamar al update scroe para que actualice.

    //ResetearScore();

    //



    void UpdateScore()
    {
        textScore.text = VariablesGlobales.score.ToString();
       // VariablesGlobales.score = 0;
    }

    public static void ResetearScore()
    {
        VariablesGlobales.score = 0;

    }



}
   