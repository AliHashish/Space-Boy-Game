using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTransparency : MonoBehaviour
{
    bool Transparent = false;
    // GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TriggerTransparency()
    {

        // if (Transparent)
        // {
        //     material.color.a = 1f; // a is alpha value, el howa transparent ad eih
        // }
        // else
        // {
        //     material.color.a = 0.5f;
        // }
        Transparent = !Transparent;
    }
}
