using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using Dummiesman;

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

    //Selecting and importing a file
    public void SelectModel()
    {
        
        modelPath = EditorUtility.OpenFilePanel("Ein Modell auswählen", "", "obj");
        GameObject myModel = new OBJLoader().Load(modelPath);

        Debug.Log(myModel.name);
    }

}
