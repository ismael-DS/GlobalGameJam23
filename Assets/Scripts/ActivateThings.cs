using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateThings : MonoBehaviour
{

     [SerializeField] GameObject body;
     [SerializeField] GameObject player;
     [SerializeField] RuntimeAnimatorController bodyNewanim;
     [SerializeField] Animator bodyAnimator;
     [SerializeField] Animator playerAnimator;

    void Awake(){

        bodyAnimator = body.GetComponent<Animator>();
        playerAnimator = player.GetComponent<Animator>();
    }
    void Start()
    {
       bodyAnimator.runtimeAnimatorController = bodyNewanim;
       playerAnimator.enabled = !playerAnimator.enabled;
       player.GetComponent<Player>().enabled = !player.GetComponent<Player>().enabled;
       player.GetComponent<PlayerStats>().enabled = !player.GetComponent<PlayerStats>().enabled;
       player.GetComponent<Player>().isGround = true;
    }

 
}
