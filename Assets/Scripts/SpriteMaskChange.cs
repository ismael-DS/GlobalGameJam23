using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMaskChange : MonoBehaviour
{
    [SerializeField] SpriteMask mask;
    [SerializeField] Sprite spr, spr2;



    void Start()
    {
        mask = GetComponent<SpriteMask>();
    }


    void ChangeSpriteMask(){
        mask.sprite = spr;
    }

    void ChangeSpriteMask2(){
        mask.sprite = spr2;
    }
    
}
