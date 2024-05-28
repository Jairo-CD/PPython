using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoCApitulo3 : MonoBehaviour
{
     private void Start()
    {
        // Buscar el componente VideoPlayer
        VideoPlayer videoPlayer = FindObjectOfType<VideoPlayer>();
        
        // Suscribirse al evento de finalización del video
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    private void OnVideoEnd(VideoPlayer videoPlayer)
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
