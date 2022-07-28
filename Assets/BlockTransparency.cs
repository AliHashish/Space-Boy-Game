using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTransparency : MonoBehaviour
{
    bool Transparent = false;
    // GameObject g;
    // Start is called before the first frame update

    SpriteRenderer rend;
    Color C;
    void Start()
    {
        rend = GetComponent<SpriteRenderer> ();
        C = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerTransparency()
    {
        // Debug.Log("d5l Trigger Transparency bta3t block 1: ");  // Prints in terminal
        // Debug.Log(rend.layer);
        if (Transparent)
        {
            C.a = 1f;
            rend.material.color = C;
            // rend.material.color.a = 1f; // a is alpha value, el howa transparent ad eih
            // aw opaque ad eih y3ny a2sod

            // el mfrood h8yr el layer le ActiveInteractible
            
        }
        else
        {
            // rend.material.color.a = 0.5f;
            C.a = 0.5f;
            rend.material.color = C;
            
            // el mfrood h8yr el layer le inactiveInteractible
        }
        Transparent = !Transparent;
    }
}
