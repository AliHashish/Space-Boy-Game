using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button1Script : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent customEvent;


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
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("XDDDDDDD ");  // Prints in terminal
        if (other.gameObject.CompareTag("Player"))
        {
            trigger = true;
            Debug.Log("Mouse Position:XDDDDDDD ");  // Prints in terminal
        }
        trigger = false;
    }
}
