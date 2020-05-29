using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Dummiesman;
using System.Collections.Specialized;
using SimpleFileBrowser;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class Import : MonoBehaviour
{
    public string modelPath;
    public GameObject myModel;
    public Vector3 spawnPosition, scaleChange;
    public GameObject player;

    public void OnMouseDown()
    {
        //Selecting and importing a file
        FileBrowser.SetFilters(true, ".obj");
        FileBrowser.SetDefaultFilter(".obj");
        FileBrowser.ShowLoadDialog((path) => { modelPath = path; }, null, false, null, "Select Model", "Select");
        //while (String.IsNullOrEmpty(modelPath) == true) { }
        //yield return new WaitUntil(() => String.IsNullOrEmpty(modelPath) == false);

        myModel = new OBJLoader().Load(modelPath);
        //myModel = new OBJLoader().Load("C:/Users/silas/Desktop/Neumatt-3D.obj");
        myModel.transform.localScale = scaleChange;
        player.transform.position = new Vector3(0, 0, 10);


    }


}


