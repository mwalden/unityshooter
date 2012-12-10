using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public bool alive;
	// Use this for initialization
	void Start () {
		alive = true;
		Debug.Log ("Startin enemy");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		alive = false;
	}
}
