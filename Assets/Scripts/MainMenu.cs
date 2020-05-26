using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking.Types;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string modelPath;

    public void StartProgram()
    {
        SceneManager.LoadSceneAsync("Galerie");
    }

    public void QuitProgram()
    {
        Application.Quit();
    }

    public void SelectModel()
    {
        modelPath = EditorUtility.OpenFilePanel("Ein Modell auswählen", "", "");
        Debug.Log(modelPath);
    }

}
