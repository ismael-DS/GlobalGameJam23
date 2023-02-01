using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMaskChange : MonoBehaviour
{
    [SerializeField] SpriteMask mask;
    [SerializeField] [Header("Mask Idle (No Damage)")] Sprite spr;
    [SerializeField] Sprite spr2;
    [SerializeField] [Header("Mask Walk (No Damage)")] Sprite spr3;
    [SerializeField] Sprite spr4, spr5, spr6;
    [SerializeField] [Header("Mask Idle 1/4")] Sprite spr7;
    [SerializeField] Sprite spr8;
    [SerializeField] [Header("Mask Walk 1/4")] Sprite spr9;
    [SerializeField] Sprite spr10, spr11, spr12;
    [SerializeField] [Header("Mask Idle 2/4")] Sprite spr13;
    [SerializeField] Sprite spr14;
    [SerializeField] [Header("Mask Walk 2/4")] Sprite spr15;
    [SerializeField] Sprite spr16, spr17, spr18;
    [SerializeField] [Header("Mask Idle 3/4")] Sprite spr19;
    [SerializeField] Sprite spr20;
    [SerializeField] [Header("Mask Walk 3/4")] Sprite spr21;
    [SerializeField] Sprite spr22, spr23, spr24;
    [SerializeField] [Header("Mask Body Die")] Sprite spr25;
    [SerializeField] Sprite spr26, spr27, spr28, spr29, spr30;



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

    void ChangeSpriteMask3(){
        mask.sprite = spr3;
    }
    void ChangeSpriteMask4(){
        mask.sprite = spr4;
    }
    void ChangeSpriteMask5(){
        mask.sprite = spr5;
    }
    void ChangeSpriteMask6(){
        mask.sprite = spr6;
    }
    void ChangeSpriteMask7(){
        mask.sprite = spr7;
    }
    void ChangeSpriteMask8(){
        mask.sprite = spr8;
    }
    void ChangeSpriteMask9(){
        mask.sprite = spr9;
    }
    void ChangeSpriteMask10(){
        mask.sprite = spr10;
    }
    void ChangeSpriteMask11(){
        mask.sprite = spr11;
    }
    void ChangeSpriteMask12(){
        mask.sprite = spr12;
    }
    void ChangeSpriteMask13(){
        mask.sprite = spr13;
    }
    void ChangeSpriteMask14(){
        mask.sprite = spr14;
    }
    void ChangeSpriteMask15(){
        mask.sprite = spr15;
    }
    void ChangeSpriteMask16(){
        mask.sprite = spr16;
    }
    void ChangeSpriteMask17(){
        mask.sprite = spr17;
    }
    void ChangeSpriteMask18(){
        mask.sprite = spr18;
    }
    void ChangeSpriteMask19(){
        mask.sprite = spr19;
    }
    void ChangeSpriteMask20(){
        mask.sprite = spr20;
    }
    void ChangeSpriteMask21(){
        mask.sprite = spr21;
    }
    void ChangeSpriteMask22(){
        mask.sprite = spr22;
    }
    void ChangeSpriteMask23(){
        mask.sprite = spr23;
    }
    void ChangeSpriteMask24(){
        mask.sprite = spr24;
    }
    void ChangeSpriteMask25(){
        mask.sprite = spr25;
    }
    void ChangeSpriteMask26(){
        mask.sprite = spr26;
    }
    void ChangeSpriteMask27(){
        mask.sprite = spr27;
    }
    void ChangeSpriteMask28(){
        mask.sprite = spr28;
    }
    void ChangeSpriteMask29(){
        mask.sprite = spr29;
    }
    void ChangeSpriteMask30(){
        mask.sprite = spr30;
    }
    
}
