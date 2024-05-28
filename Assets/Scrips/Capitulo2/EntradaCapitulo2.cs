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
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EntradaCapitulo2 : MonoBehaviour
{
    public Button BotonInputc2;
    public InputField inputFieldc2;
    public Button BotonApagadoc2;
    public GameObject panelc2;

    public bool ma1c2 = false;
    public Toggle mision1Togglec2;
    public Text mision1Textc2;
    public string m1c2 = "edad=17";

    public bool ma2c2 = false;
    public Toggle mision2Togglec2;
    public Text mision2Textc2; 
    public string m2c2 = "if(edad>=18)";

    public bool ma3c2 = false;
    public Toggle mision3Togglec2;
    public Text mision3Textc2;
    public Text mision3TextResc2;
    public string m3c2 = "print('puedepasar')";

    public bool ma4c2 = false;
    public Toggle mision4Togglec2;
    public Text mision4Textc2;
    public string m4c2 = "else:";

    public bool ma5c2 = false;
    public Toggle mision5Togglec2;
    public Text mision5Textc2;
    public Text mision5TextResc2;
    public string m5c2 = "print('nopuedepasar')";



    private void Start()
    {   
        mision1Togglec2.isOn = false;
        mision1Textc2.enabled = false;

        mision2Togglec2.isOn = false;
        mision2Textc2.enabled = false;

        mision3Togglec2.isOn = false;
        mision3Textc2.enabled = false;
        mision3TextResc2.enabled = false;

        mision4Togglec2.isOn = false;
        mision4Textc2.enabled = false;

        mision5Togglec2.isOn = false;
        mision5Textc2.enabled = false;
        mision5TextResc2.enabled = false;

        panelc2.SetActive(false);
        BotonInputc2.onClick.AddListener(GetInput);
        BotonApagadoc2.onClick.AddListener(PanelOn);
    }

    public void GetInput()
    {
        string textoIngresado = inputFieldc2.text.ToLower().Replace(" ", "");

        if(!ma1c2)
        {
            if (m1c2 == textoIngresado)
                {
                    inputFieldc2.text = "";
                    ma1c2 =true;
                    mision1Togglec2.isOn = true;
                    mision1Textc2.enabled = true;
                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma2c2)
        {
            if (m2c2 == textoIngresado)
                {   
                    inputFieldc2.text = "";
                    ma2c2 = true;
                    mision2Togglec2.isOn = true;
                    mision2Textc2.enabled = true;
                    
                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma3c2)
        {
            if (m3c2 == textoIngresado)
                {
                    inputFieldc2.text = "";
                    ma3c2 = true;
                    mision3Togglec2.isOn = true;
                    mision3Textc2.enabled = true;
                    mision3TextResc2.enabled = true;

                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma4c2)
        {
            if (m4c2 == textoIngresado)
                {
                    inputFieldc2.text = "";
                    mision3TextResc2.enabled = false;
                    ma4c2 = true;
                    mision4Togglec2.isOn = true;
                    mision4Textc2.enabled = true;
                    
                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma5c2)
        {
            if (m5c2 == textoIngresado)
                {
                    inputFieldc2.text = "";
                    ma5c2 = true;
                    mision5Togglec2.isOn = true;
                    mision5Textc2.enabled = true;
                    mision5TextResc2.enabled = true;
                    
                    reproducirHistoria();

                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else
        {
            Debug.Log("ACABO LAS MISIONES");

        }

    }

    public void PanelOn()
    {
        panelc2.SetActive(!panelc2.activeSelf);
    }

    public void Cuarto()
    {
        SceneManager.LoadScene("Capitulo2");
    }
    public void Libro()
    {
        SceneManager.LoadScene("LibroCapitulo2");
    }
    void reproducirHistoria()
    {
        StartCoroutine(ReproducirHistoriaCoroutine());
    }
    IEnumerator ReproducirHistoriaCoroutine()
    {
    yield return new WaitForSeconds(2f);
    SceneManager.LoadScene("HistoriaCapitulo2");
    }
}
