using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter2D(Collision2D coll){
            if(coll.gameObject.tag == "Player"){  
                SceneManager.LoadScene("Fase 2");
            }
        }
        
    }
}
