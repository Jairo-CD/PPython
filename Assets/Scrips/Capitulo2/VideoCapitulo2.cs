/*
 * This file is part of PPYTHON: Videojuego de los principios del lenguaje de programación.
 *
 * PPYTHON: Videojuego de los principios del lenguaje de programación is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * PPYTHON: Videojuego de los principios del lenguaje de programación is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with PPYTHON: Videojuego de los principios del lenguaje de programación. If not, see <https://www.gnu.org/licenses/>.
 */


using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoCapitulo2 : MonoBehaviour
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
        // Cambiar a la siguiente escena
        SceneManager.LoadScene("Capitulo3");
    }
}
