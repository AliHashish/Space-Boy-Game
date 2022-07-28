using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button1Script : MonoBehaviour
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
        // dh byetfy el block w yrg3o
        // if (Block.activeInHierarchy == true)
        // {
        //     Block.SetActive(false);
        // }
        // else
        // {
        //     Block.SetActive(true);
        // }
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
        // Debug.Log("Da5al On Trigger bta3t button ");  // Prints in terminal
        if (other.gameObject.CompareTag("Player"))
        {
            trigger = true;
            // Debug.Log("Da5al el if condition kaman ");  // Prints in terminal
        }
    }
}
