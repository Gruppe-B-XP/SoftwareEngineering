using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.SceneManagement;
using Dummiesman;
using System.Collections.Specialized;

public class ChangeScene : MonoBehaviour
{
    //public string NewScene;
    public string modelPath;
    public GameObject myModel;
    public Vector3 spawnPosition, scaleChange;
    public GameObject player;

    public void OnMouseDown()
    {

        //Selecting and importing a file


        modelPath = EditorUtility.OpenFilePanel("Ein Modell auswählen", "", "obj");
        myModel = new OBJLoader().Load(modelPath);
        Debug.Log(myModel.name);
        //Instantiate(myModel, this.spawnPosition, Quaternion.identity);
        // new Vector3 scaleChange2 = new Vector3(-0.001f, -0.001f, -0.001f);
        myModel.transform.localScale = scaleChange;
        player.transform.position = new Vector3(0, 0, 75);



    }
}
