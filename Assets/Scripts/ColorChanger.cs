using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [Header("LeftMenu")]
    public Material blackMaterial;
    public Material greenMaterial;
    public Material orangeMaterial;
    public Material violetMaterial;

    [Header("RightMenu")]
    public Material whiteMaterial;
    public Material blueMaterial;
    public Material redMaterial;
    public Material yellowMaterial;

    public void SetColor(string color)
    {
        switch (color)
        {
            case "black":
                SetMaterial(blackMaterial);
                break;
            case "green":
                SetMaterial(greenMaterial);
                break;
            case "orange":
                SetMaterial(orangeMaterial);
                break;
            case "violet":
                SetMaterial(violetMaterial);
                break;
            case "white":
                SetMaterial(whiteMaterial);
                break;
            case "blue":
                SetMaterial(blueMaterial);
                break;
            case "red":
                SetMaterial(redMaterial);
                break;
            case "yellow":
                SetMaterial(yellowMaterial);
                break;
        }
    }

    private void SetMaterial(Material newMaterial)
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = newMaterial;
    }
}
