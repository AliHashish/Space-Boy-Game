using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever1Script : MonoBehaviour
{

    [Header("Custom Event")]
    public UnityEvent customEvent;
    
    // 3rft object b ay esm 3ady
    // b3dein haroo7 fy unity a-attach el object dh bl ana 3ayzo
    // public GameObject Block;
    public Sprite pressedLever;

    bool trigger = false;
    bool pressed = false;

    private Sprite oldSprite;
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        oldSprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger)
        {
            customEvent.Invoke();    //hy-invoke kol el events
            trigger = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // el other dh howa el object el 5abat el button

        // Debug.Log("Da5al On Trigger bta3t button ");  // Prints in terminal
        
        // y3ny bashoof el 5bt el button dh el player wala la
        // Tag dyh htla2eeha fy awl satr kda ganb el layer fl player
        if (other.gameObject.CompareTag("Player"))
        {
            x++;
            Debug.Log(x);
            if(x%2==0)
            {
                x=0;    // b7eith adman en el x mt3mlsh overflow xD
                        // kan momkn ast3ml bool a7sn
            }
            else
            {
                trigger = true;
                pressed = !pressed;
                if(pressed)
                {
                    Debug.Log("Pressed");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = pressedLever;
                    transform.Translate(-0.57f, -0.67f, 0f);
                    // 3ayez a-offset el checkbox 2 fl x 3lshan yozbot
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(2,0);
                }
                else
                {
                    Debug.Log("NOT Pressed");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = oldSprite;
                    transform.Translate(0.57f, 0.67f, 0f);
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0,0);
                }
                // Debug.Log(x);
                // Debug.Log("Da5al el if condition kaman ");  // Prints in terminal
            }
        }
    }
}
