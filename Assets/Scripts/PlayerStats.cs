using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float playerLife;
    [SerializeField] float maxLife = 10f;
    [SerializeField] GameObject popupText;
    [SerializeField] Animator anim;
    [SerializeField] int damageTaked;
    [SerializeField] Animator headReset;
    [SerializeField] GameObject body;
    [SerializeField] GameObject head;
    [SerializeField] Vector3 player_pos;
    [SerializeField] RuntimeAnimatorController newController1, newController2, newController3, newControllerHead, newControllerHead2, newControllerHead3;

   


    // Start is called before the first frame update
    void Start()
    {
        

        anim = body.GetComponent<Animator>();
        headReset = head.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        player_pos = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, GameObject.FindGameObjectWithTag("Player").transform.position.y, GameObject.FindGameObjectWithTag("Player").transform.position.z);

        
        damageTaked = (int)(playerLife - maxLife);

        popupText.GetComponent<TMP_Text>().text = damageTaked.ToString();

        if(playerLife <= 7.5f && playerLife > 5f){
             anim.runtimeAnimatorController = newController1;
             headReset.runtimeAnimatorController = newControllerHead;
        }
        else if(playerLife <= 5f && playerLife > 2.5f){
            anim.runtimeAnimatorController = newController2;
            headReset.runtimeAnimatorController = newControllerHead2;
        }
        else if(playerLife <= 2.5f){
            anim.runtimeAnimatorController = newController3;
            headReset.runtimeAnimatorController = newControllerHead3;
        }
    }

    public void takeDamage(float damage){
        playerLife -= damage;
        Instantiate(popupText, player_pos, Quaternion.identity, transform);
    }
}
