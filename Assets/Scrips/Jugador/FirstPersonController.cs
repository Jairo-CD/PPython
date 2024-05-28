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

public class FirstPersonController : MonoBehaviour
{
    public float speed = 5f;
    public float sensitivity = 200f;
    public float gravity = 9.8f; // Ajusta el valor de gravedad según tus necesidades
    public float controllerHeight = 20f; // Altura del CharacterController
    public Camera cam;

    private CharacterController controller;
    private float xRotation = 0f;
    private Vector3 velocity; // Almacena la velocidad vertical actual

    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.height = controllerHeight; // Ajustar la altura del CharacterController
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        // Aplicar gravedad
        if (controller.isGrounded) // Si el controlador está en el suelo
        {
            velocity.y = -gravity * Time.deltaTime; // Reiniciar la velocidad vertical
        }
        else
        {
            velocity.y -= gravity * Time.deltaTime; // Aplicar aceleración gravitatoria
        }

        move += velocity; // Agregar velocidad vertical al movimiento

        controller.Move(move * speed * Time.deltaTime);

        // Rotar la cámara con las flechas del teclado
        float rotationAmount = 90f; // Ajusta la cantidad de rotación deseada
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * -rotationAmount * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationAmount * Time.deltaTime);
        }

        xRotation = 0f; // Mantener la rotación vertical en cero (sin movimiento por el ratón)
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}