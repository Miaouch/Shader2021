using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHighlight : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Material originalMat;
    public Material highlightMat;

    
    
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMat = meshRenderer.material;
    }

    void OnMouseOver(){
        meshRenderer.material = highlightMat;
    }

    void OnMouseExit(){
        meshRenderer.material = originalMat;
    }
}
