using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    public static SaveLoadManager Instance { get; private set; }
    private static string filePath;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            filePath = Application.persistentDataPath + "/gameData.txt";
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveProgress(string levelName)
    {
        File.AppendAllText(filePath, levelName + "_completed\n"); 
        Debug.Log("Progress saved to " + filePath);
    }

    public bool IsLevelCompleted(string levelName)
    {
        if (File.Exists(filePath))
        {
            string[] savedData = File.ReadAllLines(filePath);
            foreach (string line in savedData)
            {
                if (line.Contains(levelName + "_completed"))
                {
                    return true;
                }
            }
        }
        return false;
    }
}
