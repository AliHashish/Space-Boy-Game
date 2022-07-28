using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;           // 3lshan ast3ml el events

public class Button1Script : MonoBehaviour
{
    [Header("Custom Event")]            // 3lshan ast3ml el events
    public UnityEvent customEvent;
    
    [SerializeField] private AudioSource buttonSoundEffect;
    // 3rft object b ay esm 3ady
    // b3dein haroo7 fy unity a-attach el object dh bl ana 3ayzo
    // hena howa lel audio
    
    public Sprite pressedButton;        // dyh lel sora

    bool trigger = false;               // hal el player das 3leh
    bool pressed = false;               // hal howa kan mad8oot asln

    private Sprite oldSprite;           // sorto el 2adeema (msh pressed)
    int x = 0;                          // counter 3lshan yfawet wa7da mn el hitboxes bta3t el player
    // Start is called before the first frame update
    void Start()
    {
        // dh byetfy el block w yrg3o
        // if (Block.activeInHierarchy == true)
        // {
        //     Block.SetActive(false);
        // }
        // else
        // {
        //     Block.SetActive(true);
        // }
        oldSprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;      // save el sora el 2adeema
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger)         // invoke el event
        {
            customEvent.Invoke();    //hy-invoke kol el events
            trigger = false;         // rg3 el trigger false tany
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // el other dh howa el object el 5abat el button

        
        // y3ny bashoof el 5bt el button dh el player wala la
        // Tag dyh htla2eeha fy awl satr kda ganb el layer fl player
        if (other.gameObject.CompareTag("Player"))
        {
            x++;
            if(x%2==0)
            {
                x=0;    // b7eith adman en el x mt3mlsh overflow xD
                        // kan momkn ast3ml bool a7sn
            }
            else
            {
                trigger = true;         // b5leeh triggered
                pressed = !pressed;     // ba3kes el state

                // audio source
                buttonSoundEffect.Play();       // bsh8l el sfx


                // b7aded anhy sora el tet7at
                if(pressed)             
                {
                    Debug.Log("Pressed");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = pressedButton;      // b8yr el sora

                    // b7rko seka 3lshan el hitbox yozbot
                    transform.Translate(0f, -0.5f, 0f);
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0,1.4f);
                }
                else
                {
                    Debug.Log("NOT Pressed");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = oldSprite;      // b8yr el sora

                    // b7rko seka 3lshan el hitbox yozbot
                    transform.Translate(0f, 0.5f, 0f);
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0,0);
                }
            }
        }
    }
}
