using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController playerController = collision.GetComponent<PlayerController>();
        // checking if the gameobject has the playerController (meaning it's the player) or not
        if (playerController != null)
        {
            playerController.SetDamage();
        }
       
    }
}
