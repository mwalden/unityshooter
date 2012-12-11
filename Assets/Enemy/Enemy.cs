using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public bool alive;
	public Transform explosion;
	// Use this for initialization
	void Start () {
		alive = true;
		Debug.Log ("Startin enemy");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "enemy")
			return;
		StartCoroutine(explode());
		
	}
	
	private IEnumerator explode(){
		Debug.Log("exploding");
		Instantiate(explosion,transform.position,transform.rotation);
		yield return new WaitForSeconds (5);		
		alive = false;
		
	}
}
