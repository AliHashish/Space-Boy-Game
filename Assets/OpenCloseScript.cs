using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCloseScript : MonoBehaviour
{
    [SerializeField] private AudioSource winSoundEffect;        // Sound effects

    private Sprite oldSprite;               // el sprite dyh el sora, hena dyh el sora el 2adeema (bab maftoo7)
    public Sprite closedDoor;               // lama a2felo, h8yr el sora
    bool moved = false;                     // boolean by2oly a2felo wala la
    
    // Start is called before the first frame update
    void Start()
    {
        oldSprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;      // b5leeh y-save el sora el 2adeema (bab maftoo7)
        this.gameObject.GetComponent<SpriteRenderer>().sprite = closedDoor;     // y7ot wa7da mkanha (bab ma2fool)
        
        // h7rkha 0.24 le ta7t
        transform.Translate(0f, -0.24f, 0f);    // 3lshan 5ater el bab el ma2fool sorto a3la seka
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        // el other dh howa el object el 5abat el bab

        // y3ny bashoof el 5bt el bab dh el player wala la
        // Tag dyh htla2eeha fy awl satr kda ganb el layer fl player
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = oldSprite;  // b7ot soret el bab el maftoo7
            
            // audio source
            winSoundEffect.Play();      // bsh8l sot
            
            if (!moved)
            {
                transform.Translate(0f, 0.24f, 0f);     // brg3 a7rko le mkano el 2adeem
                moved = true;                           // 3lshan my7rakoosh kaza mara, hya mara wa7da bs
            }

            // Lazem startcoroutine msh TimeDelay() 3la tool, l2naha IEnumerator, msh function 3adya
            StartCoroutine(TimeDelay());
            // SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1)%3);       // gets the next level
            
        }
    }


    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(0.85f);      // waits for 1.5 seconds abl ma yen2el el level
                                                    // dh 3lshan 5ater nel7a2 nesma3 el o8nya
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1)%3);       // gets the next level
    }
}
