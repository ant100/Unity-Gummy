using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    private Image imageRender;
    // Start is called before the first frame update
    void Awake()
    {
        imageRender = gameObject.GetComponent<Image>();
        Debug.Log(imageRender);
        Invoke("CallFadeRoutine", 3f);
        
    }

    private void CallFadeRoutine()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            //Color c = imageRender.material.color;
            //c.a = ft;
            //imageRender.material.color = c;
            yield return null;
        }

        gameObject.SetActive(false);    
    }
}
