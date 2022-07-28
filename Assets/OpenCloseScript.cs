using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseScript : MonoBehaviour
{
    [SerializeField] private AudioSource winSoundEffect;

    private Sprite oldSprite;
    public Sprite closedDoor;
    bool moved = false;
    // bool reachedDoor = false;
    // int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        oldSprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = closedDoor;
        
        // h7rkha 0.24 le ta7t
        transform.Translate(0f, -0.24f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // el other dh howa el object el 5abat el button

        // Debug.Log("Da5al On Trigger bta3t button ");  // Prints in terminal
        
        // y3ny bashoof el 5bt el button dh el player wala la
        // Tag dyh htla2eeha fy awl satr kda ganb el layer fl player
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = oldSprite;
            // audio source
            winSoundEffect.Play();
            
            if (!moved)
            {
                transform.Translate(0f, 0.24f, 0f);
                moved = true;
            }

            // x++;
            // if(x%2==0)
            // {
            //     x=0;    // b7eith adman en el x mt3mlsh overflow xD
            //             // kan momkn ast3ml bool a7sn
            // }
            // else
            // {
            //     reachedDoor = !reachedDoor;
            //     if(reachedDoor)
            //     {
            //         Debug.Log("Door Reached");
            //         this.gameObject.GetComponent<SpriteRenderer>().sprite = oldSprite;
            //     }
            //     else
            //     {
            //         Debug.Log("Door Not Reached");
            //         this.gameObject.GetComponent<SpriteRenderer>().sprite = closedDoor;
            //     }
            //     // Debug.Log(x);
            //     // Debug.Log("Da5al el if condition kaman ");  // Prints in terminal
            // }
        }
    }
}
