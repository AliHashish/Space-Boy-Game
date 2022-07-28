using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRevival : MonoBehaviour
{
    public void RespawnPlayer()
    {
        // Level 1:
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
