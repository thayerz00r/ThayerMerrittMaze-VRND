using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject keyPoofPrefab; //Create a reference to the KeyPoofPrefab and Door
    public AudioClip Key_Sound;
    public GameObject key; // needed for rotation
    public Door door; //attach the door
    public bool keycollected = false; // I found this wasn't really necessary if you had to call the door.unlock() needing to be called either/or the other worked.
    public void OnKeyClicked() {
        AudioSource.PlayClipAtPoint(Key_Sound, this.gameObject.transform.position); // this audiosource doesn't go away when the object is destroyed...
        Object.Instantiate(keyPoofPrefab, transform.position, Quaternion.Euler(270, 0, 0)); // Instatiate the KeyPoof Prefab where this key is located
        door.Unlock(); // Call the Unlock() method on the Door -- this also worked using the event trigger..
        keycollected = true;
        Destroy(gameObject); // Destroy the key. Check the Unity documentation on how to use Destroy

        
        // Make sure the poof animates vertically -- OK!
        
        // Set the Key Collected Variable to true 
        
    }
	void Update()
	{
		key.transform.Rotate(Time.deltaTime * 20, Time.deltaTime * 20, Time.deltaTime * 20);
        //Not required, but for fun why not try adding a Key Floating Animation here :)
	}
}
