using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    bool locked = true;
    bool opening = false;
    float startTime = 0f;
    //public Key other;
    public Key key;
    public AudioClip Door_Opened;
    public AudioClip Door_Locked;

        void Update() {
        if (opening == true){
            if (transform.position.y <7f) // If the door is opening and it is not fully raised
            {
            transform.Translate(0, startTime, 0,Space.World );
            startTime =+ Time.deltaTime;
            }
            //Destroy(gameObject) -- I was using destroy for testing, less time than animation...
            //Debug.Log ("SayStuff");
        }
        
        
            // Animate the door raising up
    }
    public void OnDoorClicked() {
       if (key.keycollected == false) { // this also worked with if (locked == true) 
           opening = false;
           AudioSource.PlayClipAtPoint(Door_Locked, this.gameObject.transform.position); // this audiosource doesn't go away when the object is destroyed, even though still present, used to match coins and key
           //Debug.Log ("doorlocked true"); added this to figure out if it was working right commented out
        }
       else if (key.keycollected == true){
           opening = true;
           AudioSource.PlayClipAtPoint(Door_Opened, this.gameObject.transform.position); // this audiosource doesn't go away when the object is destroyed, even though still present, used to match coins and key
           //Debug.Log ("doorlocked false");

       }
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }
        public void Unlock()
        {
            locked = false; // You'll need to set "locked" to false here
            //Debug.Log ("Unlocked!"); Used to test calling of unlock method from key script
         }

}