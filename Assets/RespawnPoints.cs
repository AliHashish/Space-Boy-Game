using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;       // 3lshan a3rf ast3ml el events bta3t unity

public class RespawnPoints : MonoBehaviour
{
    [Header("Custom Event")]            // 3lshan a3rf ast3ml el events bta3t unity
    public UnityEvent customEvent;

    [SerializeField] private AudioSource respawnTeleportSoundEffect;        // dh lel audio

    bool respawn = false;           // initially, howa msh 3ayez y-get respawned

    // Update is called once per frame
    void Update()
    {
        if(respawn)     // kol shwya b-check lw m7tag a5leeh y-respawn
        {
            customEvent.Invoke();    //hy-invoke kol el events
            respawn = false;         // h3mlo respawn mara, b3dein arg3ha false tany 3lshan md5olsh fy infinite loop
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // el other dh howa el object el 3ada el line

        
        // y3ny bashoof el 3ada el line dh el player wala la
        // Tag dyh htla2eeha fy awl satr kda ganb el layer fl player
        if (other.gameObject.CompareTag("Player"))
        {
            respawn = true;         // h3mlo respawn
            
            // audio source
            respawnTeleportSoundEffect.Play();      // w ash8l el sfx bta3t el respawn
        }
    }
}
