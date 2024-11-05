using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 60f;  // El tiempo inicial en segundos.
    public Text textoTimer;    // Referencia al texto que muestra el temporizador

    // Referencia al componente MenuGameOver
    public MenuGameOver menuGameOver;

    // Variable para saber si el juego ha terminado
    private bool gameOver = false;

    void Update()
    {
        // Si el juego ya ha terminado, no hacemos nada más
        if (gameOver)
            return;

        // Reducir el temporizador con el paso del tiempo
        timer -= Time.deltaTime;
        textoTimer.text = Mathf.Max(0, timer).ToString("f0");  // Mostramos el tiempo sin valores negativos

        // Cuando el temporizador llegue a cero, mostrar el menú de Game Over
        if (timer <= 0)
        {
            // Aseguramos que no baje de cero
            timer = 0;

            // Llamamos al método de MenuGameOver() para mostrar el menú
            menuGameOver.MostrarGameOver();

            // Marcamos que el juego ha terminado
            gameOver = true;
        }
    }
}
