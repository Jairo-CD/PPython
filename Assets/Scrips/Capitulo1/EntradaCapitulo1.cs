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


public class EntradaCapitulo1 : MonoBehaviour
{   
    public Button BotonInput;
    public InputField inputField;
    public Button BotonApagado;
    public GameObject panel;

    public bool ma1 = false;
    public Toggle mision1Toggle;
    public Text mision1Text;
    public string m1 = "nombre='juan'";

    public bool ma2 = false;
    public Toggle mision2Toggle;
    public Text mision2Text; 
    public string m2 = "edad=18";

    public bool ma3 = false;
    public Toggle mision3Toggle;
    public Text mision3Text;
    public Text mision3TextRes;
    public string m3 = "print(nombre+','+str(edad))";

    public bool ma4 = false;
    public Toggle mision4Toggle;
    public Text mision4Text;
    public string m4 = "dinero=2001.07";

    public bool ma5 = false;
    public Toggle mision5Toggle;
    public Text mision5Text;
    public Text mision5TextRes;
    public string m5 = "print(type(dinero))";



    private void Start()
    {   
        mision1Toggle.isOn = false;
        mision1Text.enabled = false;

        mision2Toggle.isOn = false;
        mision2Text.enabled = false;

        mision3Toggle.isOn = false;
        mision3Text.enabled = false;
        mision3TextRes.enabled = false;

        mision4Toggle.isOn = false;
        mision4Text.enabled = false;

        mision5Toggle.isOn = false;
        mision5Text.enabled = false;
        mision5TextRes.enabled = false;

        panel.SetActive(false);
        BotonInput.onClick.AddListener(GetInput);
        BotonApagado.onClick.AddListener(PanelOn);
    }

    public void GetInput()
    {
        string textoIngresado = inputField.text.ToLower().Replace(" ", "");

        if(!ma1)
        {
            if (m1 == textoIngresado)
                {
                    inputField.text = "";
                    ma1 =true;
                    mision1Toggle.isOn = true;
                    mision1Text.enabled = true;
                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma2)
        {
            if (m2 == textoIngresado)
                {   
                    inputField.text = "";
                    ma2 = true;
                    mision2Toggle.isOn = true;
                    mision2Text.enabled = true;
                    
                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma3)
        {
            if (m3 == textoIngresado)
                {
                    inputField.text = "";
                    ma3 = true;
                    mision3Toggle.isOn = true;
                    mision3Text.enabled = true;
                    mision3TextRes.enabled = true;

                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma4)
        {
            if (m4 == textoIngresado)
                {
                    inputField.text = "";
                    ma4 = true;
                    mision4Toggle.isOn = true;
                    mision4Text.enabled = true;
                    
                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma5)
        {
            if (m5 == textoIngresado)
                {
                    inputField.text = "";
                    ma5 = true;
                    mision5Toggle.isOn = true;
                    mision5Text.enabled = true;
                    mision5TextRes.enabled = true;
                    
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
        panel.SetActive(!panel.activeSelf);
    }

    public void Cuarto()
    {
        SceneManager.LoadScene("Capitulo1");
    }
    public void Libro()
    {
        SceneManager.LoadScene("LibroCapitulo1");
    }
    void reproducirHistoria()
    {
        StartCoroutine(ReproducirHistoriaCoroutine());
    }
    IEnumerator ReproducirHistoriaCoroutine()
    {
    yield return new WaitForSeconds(2f);
    SceneManager.LoadScene("HistoriaCapitulo1");
    }
}
