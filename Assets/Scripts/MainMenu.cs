using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using Dummiesman;

public class MainMenu : MonoBehaviour
{

    public string modelPath;
    public GameObject myModel;
    public Scene sceneToLoad = SceneManager.GetSceneByName("Galerie");

    public void StartProgram()
    {
        SceneManager.LoadSceneAsync("Galerie", LoadSceneMode.Additive);
        SceneManager.MoveGameObjectToScene(myModel, sceneToLoad);
    }

    public void QuitProgram()
    {
        Application.Quit();
    }

    //Selecting and importing a file
    public void SelectModel()
    {
        
        modelPath = EditorUtility.OpenFilePanel("Ein Modell auswählen", "", "obj");
        myModel = new OBJLoader().Load(modelPath);
        Debug.Log(myModel.name);
    }

}
