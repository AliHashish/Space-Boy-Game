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
    public GameObject Block;

    bool trigger = false;


    // Start is called before the first frame update
    void Start()
    {
        
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
            trigger = true;
            // Debug.Log("Da5al el if condition kaman ");  // Prints in terminal
        }
    }
}
