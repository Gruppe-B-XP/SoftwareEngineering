using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string NewScene;
    void OnMouseDown()
    {
        SceneManager.LoadScene(NewScene);
        //Debug.Log("Scene found", NewScene);
    }
}
