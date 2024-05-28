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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesCapitulo2 : MonoBehaviour
{
    public void Cuarto()
    {
        SceneManager.LoadScene("Capitulo2");
    }
    public void Libro()
    {
        SceneManager.LoadScene("LibroCapitulo2");
    }
    public void Ordenador()
    {
        SceneManager.LoadScene("TerminalCapitulo2");
    }
}
