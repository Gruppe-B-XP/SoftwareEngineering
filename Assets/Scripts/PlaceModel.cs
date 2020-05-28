using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceModel : MonoBehaviour
{
        public Transform _theAsset;
        public Vector3 _spawnPosition;

        //Call this.Spawn() from Start() or Update() or whereever your logic triggers the spawn of the asset
        void Start()
        {
            Transform instanciatedAsset;
            //Instantiate kann keine 5 Argumente haben.
            //instanciatedAsset = (Transform)Instantiate(this._theAsset, 0,0,0, Quaternion.identity);
            //Do stuff with your instanciatedAsset ...
        }
    }
