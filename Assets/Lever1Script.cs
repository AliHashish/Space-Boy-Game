using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;       // 3lshan ast3ml el events

public class Lever1Script : MonoBehaviour
{
    // 3lshan ast3ml el events
    [Header("Custom Event")]
    public UnityEvent customEvent;
    
    [SerializeField] private AudioSource leverSoundEffect;
    // 3rft object b ay esm 3ady
    // b3dein haroo7 fy unity a-attach el object dh bl ana 3ayzo
    // hena audio
    
    public Sprite pressedLever;     // lel sora

    bool trigger = false;           // ashoof el player das 3leh wala la
    bool pressed = false;           // w hal howa kan mtdas 3leh asln

    private Sprite oldSprite;       // el sora el 2adeema (not pressed)
    int x = 0;                      // 3lshan yfawet wa7da mn el hitboxes

    // Start is called before the first frame update
    void Start()
    {
        oldSprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;      // store el sora el 2adeema
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger)     // lw etdas, invoke
        {
            customEvent.Invoke();    //hy-invoke kol el events
            trigger = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // el other dh howa el object el 5abat el lever
        
        // y3ny bashoof el 5bt el lever dh el player wala la
        // Tag dyh htla2eeha fy awl satr kda ganb el layer fl player
        if (other.gameObject.CompareTag("Player"))
        {
            x++;
            // Debug.Log(x);
            if(x%2==0)
            {
                x=0;    // b7eith adman en el x mt3mlsh overflow xD
                        // kan momkn ast3ml bool a7sn
            }
            else
            {
                trigger = true;         // 5leeh triggered
                pressed = !pressed;     // e3kes el state

                // audio source
                leverSoundEffect.Play();        // play el sfx

                // hashoof ha7ot anhy sora
                if(pressed)
                {
                    Debug.Log("Pressed");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = pressedLever;       // 8yr el sora

                    // zabat makan el sora
                    transform.Translate(-0.57f, -0.67f, 0f);
                    // 3ayez a-offset el checkbox 2 fl x 3lshan yozbot
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(2,2.3f);
                }
                else
                {
                    Debug.Log("NOT Pressed");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = oldSprite;      // 8yr el sora
                    // zabat makan el sora
                    transform.Translate(0.57f, 0.67f, 0f);
                    // hrg3 el checkbox b2a tany
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0,0);
                }
            }
        }
    }
}
