using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ReproducirVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Start()
    {
        // Suscribirse al evento loopPointReached
        videoPlayer.loopPointReached += OnVideoTerminado;
    }

    private void OnVideoTerminado(VideoPlayer vp)
    {
        // Cargar la nueva escena
        SceneManager.LoadScene("Capitulo1");
    }
}
