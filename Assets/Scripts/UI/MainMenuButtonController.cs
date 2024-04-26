using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public GameObject settingsCanvas;

    // Attach this method to the button's onClick event in the Unity Editor
    public void Play()
    {
        Debug.Log("Play clicked!");
        SceneManager.LoadScene("LevelSelection");
    }

    public void Options()
    {
        Debug.Log("Options clicked!");
        //Aqui vai abrir um UI de settings
        settingsCanvas.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Quit clicked!");
    }
}
