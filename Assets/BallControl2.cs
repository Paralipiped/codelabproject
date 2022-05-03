 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class SwipeScript : MonoBehaviour {
 
     Vector2 startPos, endPos, direction;
     Rigidbody2D myRigidbody2D;
     public  float shootPower = 10f;
 
     void Start()
     {
         myRigidbody2D = GetComponent<Rigidbody2D> ();
     }
 
     void OnMouseDown (){
         if (Input.GetMouseButtonDown (0)) {
             startPos = Input.mousePosition;
         }
     }
 
     void OnMouseUp (){
         if (Input.GetMouseButtonUp (0)) {
             endPos = Input.mousePosition;
             direction = startPos - endPos;
             myRigidbody2D.isKinematic = false;
             myRigidbody2D.AddForce (direction * shootPower);
         }
     }
 }