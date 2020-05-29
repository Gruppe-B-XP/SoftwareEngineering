using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Specialized;
using SimpleFileBrowser;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Dummiesman;

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
    StartCoroutine(ShowLoadDialogCoroutine() );
    player.transform.position = new Vector3(0, 0, 10);
    myModel.transform.localScale = scaleChange;





    }

IEnumerator ShowLoadDialogCoroutine()
{
	// Show a load file dialog and wait for a response from user
	// Load file/folder: file, Initial path: default (Documents), Title: "Load File", submit button text: "Load"
	yield return FileBrowser.WaitForLoadDialog(false, null, "Load File", "Load");
        modelPath = FileBrowser.Result;
        myModel = new OBJLoader().Load(modelPath);

        


    }
}


