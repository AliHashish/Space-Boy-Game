using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    // GameObject accepts any game object xD
    public GameObject handGun;

    _particleSystem = handGun.GetComponent<ParticleSystem>();
    bool emission = _particleSystem.emission;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePositionWrold = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        handGun.transform.LookAt(handGun.transform.position + directionToMouse);

        if (Input.GetButtonDown("Jump"))        // left mouse click
        {
            emission.enabled = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            emission.enabled = false;
        }
    }
}
