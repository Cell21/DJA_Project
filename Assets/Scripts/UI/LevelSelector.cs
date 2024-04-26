using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int level;

    public void ChangeScene()
    {
        SceneManager.LoadScene("Level"+ level.ToString());
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
