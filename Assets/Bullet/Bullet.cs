using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float velocity;
	public float maxX;
	
	// Use this for initialization
	void Start () {
		Debug.Log("started  bullet");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localPosition.x < maxX){
			transform.Translate(velocity * Time.deltaTime,0,0);
		}else{
			Destroy(transform.gameObject);
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player")
			return;
		Destroy(transform.gameObject);
		other.transform.gameObject.active=false;
	}
}
