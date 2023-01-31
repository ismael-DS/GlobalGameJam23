using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] List<Sprite> colorList = new List<Sprite>();
    [SerializeField] SpriteRenderer actualColor;
    [SerializeField] GameObject color;
    [SerializeField] int actualIndex;

    // Start is called before the first frame update
    void Start()
    {
        actualColor = color.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        actualColor.sprite = colorList[actualIndex];
    }

    public void listPlus(){
        if(actualIndex >= colorList.Count-1){
            actualIndex = 0;
        }else{
            actualIndex += 1;
        }
    }
    public void listMinus(){
        if(actualIndex <= 0){
            actualIndex = colorList.Count-1;
        }else{
            actualIndex -= 1;
        }
    }
}
