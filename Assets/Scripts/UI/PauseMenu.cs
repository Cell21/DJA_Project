using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;

    private void OnEnable()
    {
        // Garantir que o tempo está correndo quando o script é habilitado
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        Debug.Log("Options clicked!");
        // Mostrar o UI de pause
        pauseCanvas.SetActive(true);
        // Pausar o jogo
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Debug.Log("Resume clicked!");
        // Fechar o UI de pause
        pauseCanvas.SetActive(false);
        // Retomar o jogo
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        Debug.Log("MainMenu clicked!");
        // Retomar o jogo antes de carregar o menu principal
        Time.timeScale = 1f;
        // Carregar a cena do menu principal
        SceneManager.LoadScene("MainMenu");
    }

    private void OnDisable()
    {
        // Garantir que o tempo está correndo quando o script é desabilitado
        Time.timeScale = 1f;
    }
}
