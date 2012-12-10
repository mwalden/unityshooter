using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	public int maxY;
	public int minY;
	public float speed;
	public Transform bulletPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		if (transform.localPosition.y + move > minY && transform.localPosition.y + move < maxY){
			transform.Translate(0f,move,0f);
		}
		if (Input.GetButtonDown("Fire1")){
			Transform bullet = (Transform)Instantiate(bulletPrefab);
			bullet.transform.Translate(transform.localPosition);
		}
		
	}
	
	void OnTriggerEnter(Collider other){
		Debug.Log("ship hit");
	}
}
