using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPopup : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int index;
    

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.7f);
        index = Random.Range(0, 2);
    }

    void Update(){
        
        gameObject.transform.rotation = Quaternion.Euler(0, 0, Random.Range(22, -22));

        
        
        if(index == 0){
            gameObject.transform.Translate((Vector3.up + Vector3.left) * speed * Time.deltaTime);
        }
        if(index == 1){
            gameObject.transform.Translate((Vector3.up + Vector3.right) * speed * Time.deltaTime);
        }
        
        
    }


}
