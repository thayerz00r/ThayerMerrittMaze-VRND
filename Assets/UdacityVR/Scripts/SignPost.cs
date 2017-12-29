using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignPost : MonoBehaviour
{	
	//public Text coinCount;
	private int coinsCollected;
	public Text countText;
	void start() {
		coinsCollected = 0; 
		}
	public void CountCoins() {
		coinsCollected = coinsCollected +1;
		countText.text = "Coins Collected: " + coinsCollected.ToString() + " Click here to restart";
		//Debug.Log(countText.text); used for testing 
	}
	
	public void CoinCountText()
	{
		
	}
	public void ResetScene() 
	{
        SceneManager.LoadScene("A Maze");
	// Reset the scene when the user clicks the sign post
	}
}
