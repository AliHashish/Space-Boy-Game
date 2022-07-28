using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallBreak : MonoBehaviour
{
    bool Transparent = false;
    SpriteRenderer rend;
    Color C;
    int healthPoints = 5;

    private Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer> ();
        C = rend.material.color;
        healthText = GetComponentInChildren<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnParticleCollision(GameObject other) 
    {
        healthPoints--;
        if ( healthPoints <= 0)
        {
            healthPoints = 5;
            if (Transparent)
            {
                Debug.Log("Transparent");
                C.a = 1f;
                rend.material.color = C;
                // rend.material.color.a = 1f; // a is alpha value, el howa transparent ad eih
                // aw opaque ad eih y3ny a2sod

                // el mfrood h8yr el layer le ActiveInteractible
                this.gameObject.layer = 8;    // b8yr el layer
                
            }
            else
            {
                Debug.Log("NOT Transparent");
                // rend.material.color.a = 0.5f;
                C.a = 0.5f;
                rend.material.color = C;
                
                // el mfrood h8yr el layer le inactiveInteractible
                this.gameObject.layer = 11;    // b8yr el layer
            }
            Transparent = !Transparent;

        }
        Debug.Log(healthPoints);
        healthText.text = "" + healthPoints;
    }
}
