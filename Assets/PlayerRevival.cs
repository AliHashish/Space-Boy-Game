using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRevival : MonoBehaviour
{
    // bool respawn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.position);
        
    }

    public void RespawnPlayer()
    {
        // el fl nos: 40-75
        if (transform.position.x < 40)
        {
        // A: Respawn at -19, -2.2, 0
            transform.position = new Vector3(-19f, -2.2f, 0f);
        }
        else if (transform.position.x < 75)
        {
            // B: Respawn at  51, -4.2, 0
            transform.position = new Vector3(51f, -4.2f, 0f);
        }
        else
        {
            // C: Respawn at  72, -8.1, 0
            transform.position = new Vector3(72f, -8.1f, 0f);
        }
    }
}
