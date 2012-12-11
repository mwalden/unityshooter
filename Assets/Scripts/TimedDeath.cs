using UnityEngine;
using System.Collections;

public class TimedDeath : MonoBehaviour {
	public float timer = -1;
	
	
	// Update is called once per frame
	void Update () {
		if (timer == -1)
			Debug.Log("Set Timer in TimedDeath");
		timer -= Time.deltaTime;
		if (timer < 0)
			Destroy(gameObject);
	}
}
