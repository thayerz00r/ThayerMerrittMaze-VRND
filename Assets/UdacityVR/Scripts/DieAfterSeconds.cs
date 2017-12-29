using UnityEngine;
using System.Collections;

public class DieAfterSeconds : MonoBehaviour {
    IEnumerator Start () {
        yield return new WaitForSeconds(50.0f);
        Destroy(gameObject);
	}
}
