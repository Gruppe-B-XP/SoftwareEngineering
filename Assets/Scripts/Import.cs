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
        StartCoroutine(ShowLoadDialogCoroutine());
        
    }


    IEnumerator ShowLoadDialogCoroutine()
    {
	yield return FileBrowser.WaitForLoadDialog(false, null, "Suche dir ein windschnittiges Model aus", "Laden");
        if (FileBrowser.Success)
        {
            modelPath = FileBrowser.Result;
            myModel = new OBJLoader().Load(modelPath);
            player.transform.position = new Vector3(0, 0, 10);
            myModel.transform.localScale = scaleChange;
            this.GetComponent<ScreenshotHandler>().Screenshot(100,100);
        }



        }


}


