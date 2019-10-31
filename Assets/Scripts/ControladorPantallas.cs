using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorPantallas : MonoBehaviour
{
    //scene = nombre de la escene a la que queremos ir
    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
