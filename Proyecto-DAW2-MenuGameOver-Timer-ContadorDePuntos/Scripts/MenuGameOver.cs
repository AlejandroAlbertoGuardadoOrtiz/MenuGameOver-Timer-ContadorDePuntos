using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    // Referencia al Canvas del Game Over
    public GameObject gameOverCanvas;

    // Método para reiniciar el nivel actual
    public void Reiniciar()
    {
        // Carga la escena actual de nuevo
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Método para cargar el menú inicial u otra escena especificada
    public void MenuInicial(string nombre)
    {
        // Carga una escena específica (como un menú principal)
        SceneManager.LoadScene(nombre);
    }

    // Método para salir del juego
    public void Salir()
    {
        // Si estamos en el editor, detiene el modo de juego
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        // Si estamos en el juego final, cierra la aplicación
        Application.Quit();
        #endif
    }

    // Método para mostrar el menú de Game Over
    public void MostrarGameOver()
    {
        Debug.Log("Game Over! El tiempo ha terminado.");
        
        // Activar el Canvas de Game Over si existe
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true);
        }
    }
}
