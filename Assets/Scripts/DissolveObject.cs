using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject : MonoBehaviour
{
    private MeshRenderer render;
    public float finalValue = 0f;
    

    void Start()
    {
        render = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        float currentValue =render.material.GetFloat("_Dissolution");

        float newValue = Mathf.Lerp(currentValue, finalValue, Time.deltaTime); //le lerp fait avancé entre deux infox à la vitesse du temps
        //Lerp(a, b, t) a + t * (b - a)
        render.material.SetFloat("_Dissolution", newValue);
    }

    void OnMouseDown(){ //méthode quand on click
        finalValue = 1f;
        
    }

    private IEnumerator TimeDissolving(float timing){
        yield return new WaitForSeconds(timing);
    }
}
