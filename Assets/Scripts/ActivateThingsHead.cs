using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateThingsHead : MonoBehaviour
{
     [SerializeField] GameObject head;
     [SerializeField] RuntimeAnimatorController headNewanim;
     [SerializeField] Animator headAnimator;

    void Awake(){

        headAnimator = head.GetComponent<Animator>();
    }
    void Start()
    {
       headAnimator.runtimeAnimatorController = headNewanim;
    }

 
}
