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
        modelPath = EditorUtility.OpenFilePanel("Ein Modell auswählen", "", "");
        //TODO: Model importieren
        
        //TODO: Model in Scene einfügen

        Debug.Log(modelPath);
    }

}
