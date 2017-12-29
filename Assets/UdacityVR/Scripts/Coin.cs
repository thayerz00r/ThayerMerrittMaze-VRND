using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

    public GameObject coinPoofPrefab;
    public AudioClip Coin_Sound;
    public SignPost signPost; //had this to allow for coin counting + display
    public GameObject coin; //added for rotation

    public void OnCoinClicked() {
        Object.Instantiate(coinPoofPrefab, transform.position, Quaternion.Euler(270, 0, 0)); // Instantiate the CoinPoof Prefab where this coin is located
        AudioSource.PlayClipAtPoint(Coin_Sound, this.gameObject.transform.position); // this audiosource doesn't go away when the object is destroyed...
        signPost.CountCoins();
        Destroy(gameObject); // Destroy this coin. Check the Unity documentation on how to use Destroy
                      
    }
    void Update()
	{
		coin.transform.Rotate(Time.deltaTime * 50, Time.deltaTime * 50, Time.deltaTime * 50);
        //Not required, but for fun why not try adding a Key Floating Animation here :)
	}

}
