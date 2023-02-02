using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sky : MonoBehaviour
{
    [SerializeField] RawImage _img;
    [SerializeField] float x,y;
    // Start is called before the first frame update

    void Start(){
        _img = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(x,y) * Time.deltaTime, _img.uvRect.size);
    }
}
