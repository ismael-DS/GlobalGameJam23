using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    [SerializeField] GameObject cutsceneToActivate;
    [SerializeField] GameObject Player;
    [SerializeField] Vector3 playerPos;
    [SerializeField] RuntimeAnimatorController anim;
    [SerializeField] GameObject body;
    [SerializeField] GameObject head;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag == "Player")
            Player.GetComponent<Player>().canMove = false;
            Player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            body.GetComponent<Animator>().SetBool("isIdle", true);
            body.GetComponent<Animator>().SetBool("isJumping", false);
            body.GetComponent<Animator>().SetBool("isWalking", false);
            head.GetComponent<Animator>().SetBool("isIdle", true);
            head.GetComponent<Animator>().SetBool("isJumping", false);
            head.GetComponent<Animator>().SetBool("isWalking", false);
            cutsceneToActivate.SetActive(true);
        }
        
    }

