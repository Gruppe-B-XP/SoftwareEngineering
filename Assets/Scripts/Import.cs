using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
using Dummiesman;
using System.Collections.Specialized;
using SimpleFileBrowser;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class Import : MonoBehaviour
{
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
using Dummiesman;
using System.Collections.Specialized;
using SimpleFileBrowser;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class ChangeScene : MonoBehaviour
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
        FileBrowser.ShowLoadDialog((path) => { modelPath = path; }, () => { }, false, null, "Select Model", "Select");
        while (String.IsNullOrEmpty(modelPath) == true)
        {
            print("wait");
        }
        //yield return new WaitUntil(() => String.IsNullOrEmpty(modelPath) == false);

        myModel = new OBJLoader().Load(modelPath);
        //myModel = new OBJLoader().Load("C:/Users/silas/Desktop/Neumatt-3D.obj");
        myModel.transform.localScale = scaleChange;
        //myModel.GetComponentInChildren<Renderer>().material = "blue" ;
        player.transform.position = new Vector3(0, 0, 10);


    }


}

}

