using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       // 3lshan el text

public class WallBreak : MonoBehaviour
{

    bool Transparent = false;   // initially msh transparent

    // global variables hst3mlhom 3lshan el fade in/out
    SpriteRenderer rend;        
    Color C;


    int healthPoints = 5;       // el health bta3 el block

    private Text healthText;    // 3lshan a-display el health

    // Start is called before the first frame update
    void Start()
    {
        // bageeb el lon el bade2 byh
        rend = GetComponent<SpriteRenderer> ();
        C = rend.material.color;
        
        // b8yr el text el maktoob 3l box
        healthText = GetComponentInChildren<Text> ();
    }

    
    private void OnParticleCollision(GameObject other) 
    {
        // lw 7aga 5abateto, 2alel el health wa7da
        healthPoints--;
        if ( healthPoints <= 0)     // lw b2a a2al mn zero, raga3o zy ma kan, w e3kes el state
        {
            healthPoints = 5;

            // hashoof h5leeh transparent wala opaque
            if (Transparent)
            {
                // Debug.Log("Transparent"); // el mfrood Opaque
                C.a = 1f;       
                rend.material.color = C;
                // rend.material.color.a = 1f; // a is alpha value, el howa transparent ad eih
                // aw opaque ad eih y3ny a2sod

                // el mfrood h8yr el layer le ActiveInteractible
                this.gameObject.layer = 8;    // b8yr el layer, 8 dh rakamo
                
            }
            else
            {
                // Debug.Log("NOT Transparent"); // el mfrood Transparent
                // rend.material.color.a = 0.5f;
                C.a = 0.5f;
                rend.material.color = C;
                
                // el mfrood h8yr el layer le RevivableBlocks
                this.gameObject.layer = 11;    // b8yr el layer
            }
            Transparent = !Transparent;     // ba3kes el state

        }
        Debug.Log(healthPoints);            // b-display el health bar
        healthText.text = "" + healthPoints;    // 3lshan a5ly el int string
    }
}
