using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canasta : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    public GameObject Ropa1;
    public GameObject Ropa2;
    public GameObject Ropa3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (GetComponent<RectTransform>().localPosition.x >= -800)
            {
                GetComponent<RectTransform>().Translate(-moveSpeed * Time.deltaTime, 0, 0);
            } else
            {
                GetComponent<RectTransform>().localPosition = new Vector3(-800,-461,0);
            }

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);

        }

        Debug.Log(VariablesGlobales.score);

    }

 
}
