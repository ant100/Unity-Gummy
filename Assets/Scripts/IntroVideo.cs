using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroVideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    //public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVideo());
    }
    IEnumerator PlayVideo()
    {
       videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
        videoPlayer.loopPointReached += LoadScene;
        //audioSource.Play();
    }

    private string PlayVideoo()
    {
        throw new NotImplementedException();
    }

    void LoadScene(VideoPlayer videoPlayer) {
        SceneManager.LoadScene("Inicio");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
