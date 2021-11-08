using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject3 : MonoBehaviour
{
    private MeshRenderer render;
    public float duration =2f;
    private float timer = 0;
    private bool running = false;

    void Start()
    {
        render = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (running && timer < duration){
            timer += Time.deltaTime;
            float newValue =timer / duration;
            render.material.SetFloat("_Dissolution", newValue);
        }
    }

    void OnMouseDown(){ //méthode quand on click
       
        running = true;
    }

    // IEnumerator Dissolve(){
    //     float stratTime = Time.time;
    //     while (Time.time - stratTime < duration){
    //         float newValue =Time.time -stratTime;
    //         render.material.SetFloat("_Dissolution", newValue);
    //         yield return true;
    //     }
    // }
}
