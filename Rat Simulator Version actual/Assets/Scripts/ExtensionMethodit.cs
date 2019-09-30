using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethodit 
{
    public static void LosCollider(this Collider collider) // Manejar metodos que se hagan solo una vez al dar Start
    {
        collider.isTrigger = true;
    }

    public static void REset(this Transform posxyz)
    {
        posxyz.position = new Vector3(2.8f,2.28f,-13.78f);
    }


    public static void ColorNegro(this Renderer render)
    {
        render.material.color = Color.black;
    }

    public static void PonerGravedad(this Rigidbody rb)
    {
        rb.useGravity = false;
    }

    public static void AnimatorrPalo(this Animator rb)
    {
        rb.PlayInFixedTime("Palotumba 0");
    }

    public static void AnimatorrPaloPrincipal(this Animator rb)
    {
        rb.PlayInFixedTime("TumbarPalito");
    }


}
