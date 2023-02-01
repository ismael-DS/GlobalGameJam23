using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlataform : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] int startPoint, i;
    [SerializeField] Transform[] points;

    // Start is called before the first frame update
    void Start()
    {  
       transform.position = points[startPoint].position; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, points[i].position) < 0.02f){
            i++;
            if(i == points.Length){
                i = 0;
            }
       }
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed*Time.deltaTime);
        
    }

    void OnCollisionEnter2D(Collision2D coll){
        coll.transform.SetParent(transform);
    }
    void OnCollisionExit2D(Collision2D coll){
        coll.transform.SetParent(null);
    }
}
