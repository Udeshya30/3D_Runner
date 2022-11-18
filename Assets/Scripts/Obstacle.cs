using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour {

    PlayerController playerController;

	private void Start () {
        playerController = GameObject.FindObjectOfType<PlayerController>();
 
	}

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            // Reduce player life
            if (GameManager.inst.life != 0)
            {
                GameManager.inst.DecreaseLife();
                Destroy(this.gameObject);
            }
            else
            {
                // Kill the player
                GameManager.inst.DecreaseLife();
                playerController.reload.gameObject.SetActive(true);
                playerController.Die();
                Time.timeScale = 0;
                //AudioListener.volume = 0;
            } 
        }
    }


}