using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{  float speed = 0.5f;
    int point = 0;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D)){
        transform.Translate(Vector2.right * speed);}

      if(Input.GetKey(KeyCode.A)){
        transform.Translate(Vector2.right * -speed);}
    }


    void OnTriggerEnter2D(Collider2D col){

        if(col.gameObject.tag == "ball"){
       // print(col.gameObject.tag);
        Destroy(col.gameObject);
          point++;
          print(point);
          }
         if(col.gameObject.tag =="bomb"){
              Destroy(col.gameObject);
              Destroy(gameObject);
              print("restart");
              }
    }       



    void OnBecameInvisible(){
       Destroy(gameObject);


    }
}
