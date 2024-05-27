using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMarks : MonoBehaviour
{
    public GameObject[] levelCheckmarks; // Array de objetos UI de marca de verificação

    private void Start()
    {
        for (int i = 0; i < levelCheckmarks.Length; i++)
        {
            string levelName = "Level" + (i + 1); // Supondo que os níveis sejam nomeados como "Level1", "Level2", etc.
            if (SaveLoadManager.Instance.IsLevelCompleted(levelName))
            {
                levelCheckmarks[i].SetActive(true);
            }
            else
            {
                levelCheckmarks[i].SetActive(false);
            }
        }
    }
}
