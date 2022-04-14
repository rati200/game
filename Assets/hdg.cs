using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hdg : MonoBehaviour
 { //public GameObject Box;

 
   void OnBecameInvisible(){
      // Destroy(gameObject);
    if(gameObject.tag == "ball"){
        Destroy(gameObject);
        //Destroy(gameObject.tag == "Box");
    }
      if(gameObject.tag == "bomb"){
        Destroy(gameObject);
      }
       
    }
    


   

}
