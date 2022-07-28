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

    // private GameObject m_Rigidbody2D;    // hyshawer 3l block nafso
    // public GameObject Block;        // el block byshawer 3la nafso
    // this.gameObject // dh el bygeeb el object 3la tool, bdl el e3aqa bta3tk

    void Start()
    {
        // m_Rigidbody2D = GetComponent<GameObject>();
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
        // Debug.Log(this.gameObject.layer);
        if (Transparent)
        {
            C.a = 1f;
            rend.material.color = C;
            // rend.material.color.a = 1f; // a is alpha value, el howa transparent ad eih
            // aw opaque ad eih y3ny a2sod

            // el mfrood h8yr el layer le ActiveInteractible
            this.gameObject.layer = 8;    // b8yr el layer
            
        }
        else
        {
            // rend.material.color.a = 0.5f;
            C.a = 0.5f;
            rend.material.color = C;
            
            // el mfrood h8yr el layer le inactiveInteractible
            this.gameObject.layer = 9;    // b8yr el layer
        }
        Transparent = !Transparent;
    }
}
