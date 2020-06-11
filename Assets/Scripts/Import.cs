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
    public GameObject galerie;
    public ScreenshotHandler screenshot;

    public bool galerie_toggle = true;

    public void OnMouseDown()
    {
        //Selecting and importing a file
        FileBrowser.SetFilters(true, ".obj");
        FileBrowser.SetDefaultFilter(".obj");
        StartCoroutine(ShowLoadDialogCoroutine());

    }

    //Coroutine for import
    IEnumerator ShowLoadDialogCoroutine()
    {
        yield return FileBrowser.WaitForLoadDialog(false, null, "Suche dir ein windschnittiges Model aus", "Laden");
        if (FileBrowser.Success)
        {
            modelPath = FileBrowser.Result;
        }
        myModel = new OBJLoader().Load(modelPath);
        myModel.transform.position = spawnPosition;
        myModel.transform.localScale = scaleChange;
        screenshot.Screenshot(100,100);
    }
    public void scaleDown()
    {
        myModel.transform.localScale = myModel.transform.localScale * 0.5f;
    }

    public void scaleUp()
    {
        myModel.transform.localScale = myModel.transform.localScale * 2;
    }

    public void rotate()
    {
        var rotationVector = myModel.transform.rotation.eulerAngles;
        rotationVector.x = -90;
        myModel.transform.rotation = Quaternion.Euler(rotationVector);
    }

    public void hideGalarie()
    {
        if(galerie_toggle) {
            galerie.SetActive(!galerie.activeSelf);
        } else {
            galerie.SetActive(galerie.activeSelf);
            player.transform.position = spawnPosition;
        }
    }
}