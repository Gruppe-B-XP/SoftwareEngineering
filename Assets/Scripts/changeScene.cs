using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    //[SerializeField] private string model;
    public void ButtonMoveScene(string model)
    {
        SceneManager.LoadScene(model);
    }
}
