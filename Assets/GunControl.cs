using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    // GameObject accepts any game object xD
    public GameObject handGun;
    public ParticleSystem _particleSystem;
    // var emission = _particleSystem.emission;
    // Start is called before the first frame update
    void Start()
    {
      _particleSystem = GameObject.Find("HandGun").GetComponent<ParticleSystem>();      // barboto bl handgun el ana 3amelha
      var emission= _particleSystem.emission;
      emission.enabled=false;                                                           // el emissions fl awl false
    }

    // Update is called once per frame
    void Update()
    {
        var emission= _particleSystem.emission;
        
        if (Input.GetButtonDown("Fire1"))        // left mouse click
        {
            // lw das, 5leeha true
            // _particleSystem.startSpeed += Vector2.SqrMagnitude()     // lw 3ayez t3adel el speed
            emission.enabled = true;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            // lw sab, 5leeha false
            emission.enabled = false;
        }


        // 3lshan yemshy wara el mouse
        Vector3 mousePositionWrold = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 directionToMouse = mousePositionWrold - handGun.transform.position;
        handGun.transform.LookAt(handGun.transform.position + directionToMouse);
        
        
        // Debug.Log("Mouse Position: ");  // Prints in terminal
        // Debug.Log(mousePositionWrold);

        // Debug.Log("el baro7lo: ");  // Prints in terminal
        // Debug.Log(handGun.transform.position + directionToMouse - mousePositionWrold);

    }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     Debug.Log("Trigger!");  // Prints in terminal
    // }

    // private void OnCollisionEnter2D(Collision2D other) 
    // {
    //     Debug.Log("Trigger2!");  // Prints in terminal 
    // }
}
