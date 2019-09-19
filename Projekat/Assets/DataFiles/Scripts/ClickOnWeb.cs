using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
public class ClickOnWeb : MonoBehaviour
{
    MeshRenderer mesh;
   void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void OnMouseDown()
    {
        if(gameObject.name == "Tricikl")
        {
            Application.OpenURL("http://www.tricikl.rs/");
        }
        else if(gameObject.name == "Instagram")
        {
            Application.OpenURL("https://www.instagram.com/tricikl_shop/");
        }
        else if(gameObject.name == "Lomo")
        {
            Application.OpenURL("https://shop.lomography.com/en/lomoinstant-automat-playa-jardin");
        }
    }
}
