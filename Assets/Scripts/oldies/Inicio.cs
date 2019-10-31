using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ResetearScore();
    }

   public void ResetearScore()
    {
        VariablesGlobales.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
