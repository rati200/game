using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{ public GameObject ball;
  public GameObject bomb;


void Start (){
    InvokeRepeating("dropBall", 2, 3);
   InvokeRepeating("dropBomb", 5, 1);
   
}




    void dropBall()
    {
        float x = Random.Range(-9.8f, 9.8f);
        float y = Random.Range(10f, 10f);
        Vector2 myVector = new Vector2(x,y);
   Instantiate(ball, myVector, Quaternion.identity);

    }

    void dropBomb(){
        float x = Random.Range(-9.8f, 9.8f);
       float y = Random.Range(10f, 10f);
       Vector2 myVector = new Vector2(x,y);
       Instantiate(bomb, myVector, Quaternion.identity);

    }
    
}
