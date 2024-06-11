using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public string levelName;
    private void OnTriggerEnter(Collider other)
    {
        //Som de vitória
        FindObjectOfType<AudioManager>().PlaySound("Win");
        // Salvar o progresso do jogador
        SaveLoadManager.Instance.SaveProgress(levelName);
        Debug.Log("Level " + levelName + " completed!");
        SceneManager.LoadScene("LevelSelection");
    }
}
