using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button1Script : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent customEvent;
    
    [SerializeField] private AudioSource buttonSoundEffect;
    // 3rft object b ay esm 3ady
    // b3dein haroo7 fy unity a-attach el object dh bl ana 3ayzo
    // public GameObject Block;
    
    public Sprite pressedButton;

    bool trigger = false;
    bool pressed = false;

    private Sprite oldSprite;
    int x = 0;
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
            if(x%2==0)
            {
                x=0;    // b7eith adman en el x mt3mlsh overflow xD
                        // kan momkn ast3ml bool a7sn
            }
            else
            {
                trigger = true;
                pressed = !pressed;
                // audio source
                buttonSoundEffect.Play();
                if(pressed)
                {
                    Debug.Log("Pressed");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = pressedButton;
                    transform.Translate(0f, -0.5f, 0f);
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0,1.4f);
                }
                else
                {
                    Debug.Log("NOT Pressed");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = oldSprite;
                    transform.Translate(0f, 0.5f, 0f);
                    this.gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0,0);
                }
                // Debug.Log(x);
                // Debug.Log("Da5al el if condition kaman ");  // Prints in terminal
            }
        }
    }
}
