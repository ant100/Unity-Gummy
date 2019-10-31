using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ropa : MonoBehaviour
{
    //public VariablesGlobales referencia;

    public int puntaje = 0;

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RectTransform>().Translate(0, -moveSpeed * Time.deltaTime, 0);

        Debug.Log(VariablesGlobales.score);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        VariablesGlobales.score= VariablesGlobales.score+1;
    }
}
