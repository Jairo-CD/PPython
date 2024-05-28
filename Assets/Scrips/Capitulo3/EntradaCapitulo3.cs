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

public class EntradaCapitulo3 : MonoBehaviour
{
   public Button BotonInputc3;
    public InputField inputFieldc3;
    public Button BotonApagadoc3;
    public GameObject panelc3;

    public bool ma1c3 = false;
    public Toggle mision1Togglec3;
    public Text mision1Textc3;
    public string m1c3 = "informacion ={'nombre':'juan','edad':18,'sexo':'hombre'}";

    public bool ma2c3 = false;
    public Toggle mision2Togglec3;
    public Text mision2Textc3;
    public Text mision2TextResc3; 
    public string m2c3 = "print(informacion)";

    public bool ma3c3 = false;
    public Toggle mision3Togglec3;
    public Text mision3Textc3;
    public string m3c3 = "informacion['dinero']=2001.07";

    public bool ma4c3 = false;
    public Toggle mision4Togglec3;
    public Text mision4Textc3;
    public Text mision4TextResc3; 
    public string m4c3 = "print(informacion)";

    private void Start()
    {   
        mision1Togglec3.isOn = false;
        mision1Textc3.enabled = false;

        mision2Togglec3.isOn = false;
        mision2Textc3.enabled = false;
        mision2TextResc3.enabled = false;

        mision3Togglec3.isOn = false;
        mision3Textc3.enabled = false;

        mision4Togglec3.isOn = false;
        mision4Textc3.enabled = false;
        mision4TextResc3.enabled = false;



        panelc3.SetActive(false);
        BotonInputc3.onClick.AddListener(GetInput);
        BotonApagadoc3.onClick.AddListener(PanelOn);
    }

    public void GetInput()
    {
        string textoIngresado = inputFieldc3.text.ToLower().Replace(" ", "");

        if(!ma1c3)
        {
            if (m1c3 == textoIngresado)
                {
                    inputFieldc3.text = "";
                    ma1c3 =true;
                    mision1Togglec3.isOn = true;
                    mision1Textc3.enabled = true;
                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma2c3)
        {
            if (m2c3 == textoIngresado)
                {   
                    inputFieldc3.text = "";
                    ma2c3 = true;
                    mision2Togglec3.isOn = true;
                    mision2Textc3.enabled = true;
                    mision2TextResc3.enabled = true;
                    
                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma3c3)
        {
            if (m3c3 == textoIngresado)
                {
                    inputFieldc3.text = "";
                    ma3c3 = true;
                    mision3Togglec3.isOn = true;
                    mision3Textc3.enabled = true;
                    

                }else
                {
                    Debug.Log("El texto ingresado es diferente a la variable declarada");
                }
        }else if(!ma4c3)
        {
            if (m4c3 == textoIngresado)
                {
                    inputFieldc3.text = "";
                    ma4c3 = true;
                    mision4Togglec3.isOn = true;
                    mision4Textc3.enabled = true;
                    mision4TextResc3.enabled = true;
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
        panelc3.SetActive(!panelc3.activeSelf);
    }

    public void Cuarto()
    {
        SceneManager.LoadScene("Capitulo3");
    }
    public void Libro()
    {
        SceneManager.LoadScene("LibroCapitulo3");
    }
    void reproducirHistoria()
    {
        StartCoroutine(ReproducirHistoriaCoroutine());
    }
    IEnumerator ReproducirHistoriaCoroutine()
    {
    yield return new WaitForSeconds(2f);
    SceneManager.LoadScene("HistoriaCapitulo3");
    }
}
