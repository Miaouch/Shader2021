using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject2 : MonoBehaviour
{
    private MeshRenderer render;
    public float duration =2f;
    

    void Start()
    {
        render = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){ //méthode quand on click
       
        StartCoroutine(Dissolve());
    }

    IEnumerator Dissolve(){
        float stratTime = Time.time;
        while (Time.time - stratTime < duration){
            float newValue =Time.time -stratTime;
            render.material.SetFloat("_Dissolution", newValue);
            yield return true;
            // yield return new WaitForEndOfFrame(); c'est pareil que yield return true
        }
    }
}
