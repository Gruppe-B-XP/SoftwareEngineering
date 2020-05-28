using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using Dummiesman;
using System.Collections;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour
{

    public string modelPath;
    public GameObject myModel;
    //public Scene sceneToLoad = SceneManager.GetSceneByName("Galerie");
    public Vector3 spawnPosition;

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
        myModel = new OBJLoader().Load(modelPath);
        Debug.Log(myModel.name);
        Instantiate(myModel, this.spawnPosition, Quaternion.identity);
    }

}
