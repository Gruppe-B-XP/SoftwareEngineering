using UnityEditor;
using UnityEngine;
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
        // Folgendes kann nicht funktionieren. Macht das bitte anders.
        // Siehe https://stackoverflow.com/questions/56813826/unity-build-error-the-name-editorutility-does-not-exist-in-the-current-contex
        // Vielen Dank
        // modelPath = EditorUtility.OpenFilePanel("Ein Modell auswählen", "", "");
        Debug.Log(modelPath);
    }

}
