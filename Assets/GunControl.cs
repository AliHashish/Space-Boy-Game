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
      _particleSystem = GameObject.Find("HandGun").GetComponent<ParticleSystem>();
      var emission= _particleSystem.emission;
      emission.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        var emission= _particleSystem.emission;
        
        if (Input.GetButtonDown("Fire1"))        // left mouse click
        {
            // _particleSystem.startSpeed += Vector2.SqrMagnitude()
            emission.enabled = true;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            emission.enabled = false;
        }

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
