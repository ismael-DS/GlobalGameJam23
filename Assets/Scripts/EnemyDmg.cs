using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDmg : MonoBehaviour
{


    [SerializeField] float attackDmg;
    [SerializeField] GameObject P;
    [SerializeField] Player p1;
    
    
    // Start is called before the first frame update
    void Start()
    {
        p1 = P.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag == "ant"){
            coll.gameObject.GetComponent<ant>().takeDamage(2f);
        }
    }
    void disable(){
        p1.disableAttack();
    }
}
