using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceModel : MonoBehaviour
{
    public Transform model;
    public Vector3 spawnPosition, scaleChange;

    //The model only needs placement before the first image is rendered
    void Start()
    {
        Transform instanciatedAsset;
        instanciatedAsset = (Transform)Instantiate(this.model, this.spawnPosition, Quaternion.identity);

        Renderer rend = instanciatedAsset.GetComponent<Renderer>();
        rend.material = Resources.Load<Material>("blue");
        GameObject instModel = instanciatedAsset.GetComponent<GameObject>();
        instanciatedAsset.transform.localScale = new Vector3(transform.localScale.x, 500F, transform.localScale.y);

    }


}
