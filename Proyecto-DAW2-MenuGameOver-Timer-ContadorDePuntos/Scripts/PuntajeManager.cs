using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Necesario para usar TextMeshProUGUI

public class PuntajeManager : MonoBehaviour
{
    // Puntos actuales del jugador.
    private int puntos;

    // Referencia a un componente TextMeshProUGUI en la interfaz para mostrar los puntos.
    public TextMeshProUGUI puntajeTexto;

    // Método para inicializar el puntaje.
    void Start()
    {
        puntos = 0;
        ActualizarPuntajeUI();
    }

    // Método para manejar la entrega de pedidos y actualizar puntos.
    public void EntregarPedido(bool pedidoCompletado, int tiempo, bool especial = false)
    {
        if (pedidoCompletado)
        {
            // Puntos base por entregar el pedido.
            puntos += 10;

            /*
            // Bonificación si el pedido es especial.
            if (especial)
            {
                puntos += 5;
            }

            // Bonificación por entrega rápida.
            if (tiempo < 30)
            {
                puntos += 3;
            }
            */
        }
        else
        {
            // Penalización si el pedido no se entrega correctamente.
            puntos -= 5;
        }

        // Actualiza el puntaje en la interfaz.
        ActualizarPuntajeUI();
    }

    // Método para actualizar el texto del puntaje en la interfaz.
    private void ActualizarPuntajeUI()
    {
        if (puntajeTexto != null)
        {
            puntajeTexto.text = "Puntos: " + puntos;
        }
    }

    // Método para obtener el puntaje actual
    public int ObtenerPuntaje()
    {
        return puntos;
    }

    /*
    void Update()
    {
        // Para pruebas: suma puntos cuando presionas la tecla P.
        if (Input.GetKeyDown(KeyCode.P))
        {
            EntregarPedido(true, 25, true);  // Pedido entregado, con bonificación de tiempo y especial.
            Debug.Log("Pedido entregado con bonificación. Puntos: " + puntos);
        }

        // Para pruebas: resta puntos cuando presionas la tecla O.
        if (Input.GetKeyDown(KeyCode.O))
        {
            EntregarPedido(false, 40);  // Pedido no entregado correctamente.
            Debug.Log("Pedido fallido. Puntos: " + puntos);
        }
    }
    */

}
